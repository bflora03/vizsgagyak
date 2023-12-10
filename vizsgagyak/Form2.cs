using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace vizsgagyak
{
    public partial class Form2 : Form
    {
        Models.RendelesContext context = new Models.RendelesContext();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form2()
        {
            InitializeComponent();
        }

        public void TáblázatKészítés()
        {
            string[] fejlécek = new string[]
            { //lehet itt lesz a hiba !!!!!
                "Megnevezés",
                "Termékkód",
                "Listaár",
                "Megység",
                "Készlet",
            };

            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }

            var adatok = context.Termek.ToList();

            object[,] adatTömb = new object[adatok.Count(), fejlécek.Count()];
            for (int i = 0; i < adatok.Count(); i++)
            {
                adatTömb[i, 0] = adatok[i].Megnevezes;
                adatTömb[i, 1] = adatok[i].Termekkod;
                adatTömb[i, 2] = adatok[i].Listaar;
                adatTömb[i, 3] = adatok[i].Megys;
                adatTömb[i, 4] = adatok[i].Keszlet;

            }

            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;
            adatRange.Columns.AutoFit();

            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 5);
            fejllécRange.Font.Bold = true;

            fejllécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejllécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejllécRange.EntireColumn.AutoFit();
            fejllécRange.RowHeight = 60;
            fejllécRange.Interior.Color = Color.Aqua;
            fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Excel elindítása
                xlApp = new Excel.Application();

                //Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                //Új munkalap
                xlSheet = xlWB.ActiveSheet;

                //Tábla létrehozása
                TáblázatKészítés();

                //Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {

                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                //Hiba esetén az applikáció automatikus bezárása
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            worksheet.Cells[1, "A"] = "Data Set";
            worksheet.Cells[1, "B"] = "Value";
            worksheet.Cells[2, "A"] = "Point 1";
            worksheet.Cells[2, "B"] = 10;
            worksheet.Cells[3, "A"] = "Point 2";
            worksheet.Cells[3, "B"] = 20;
            worksheet.Cells[4, "A"] = "Point 3";
            worksheet.Cells[4, "B"] = 30;
            worksheet.Cells[5, "A"] = "Point 4";
            worksheet.Cells[5, "B"] = 40;

            //?
            Excel.Range chartRange = worksheet.get_Range("A1", "B5");


            Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;


            chartPage.SetSourceData(chartRange);

            chartPage.ChartType = Excel.XlChartType.xlLine;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Example Chart",
                CategoryTitle: "Data Set",
                ValueTitle: "Value");
        }
    }
}
