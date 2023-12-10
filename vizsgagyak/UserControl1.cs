using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vizsgagyak.Models;

namespace vizsgagyak
{
    public partial class UserControl1 : UserControl
    {
        Models.RendelesContext context = new Models.RendelesContext();
        public UserControl1()
        {
            InitializeComponent();
            ÜgyfélSzűrés();
            RendelesListazas();
        }

        private void ÜgyfélSzűrés()
        {
            var ugyfel = from x in context.Ugyfel
                         where x.Nev.Contains(textBoxÜgyfélSzűrés.Text)
                         select x;
            listBoxÜgyfelek.DataSource = ugyfel.ToList();
            listBoxÜgyfelek.DisplayMember = "Nev";
        }
        private void textBoxÜgyfélSzűrés_TextChanged(object sender, EventArgs e)
        {
            ÜgyfélSzűrés();
        }
        private void RendelesListazas()
        {
            var selugyfel = ((Ugyfel)listBoxÜgyfelek.SelectedItem).Login;
            var rendelesek = from x in context.Rendeles
                             where x.Login == selugyfel
                             select new RendelesDetail
                             {
                                 Sorszam = x.Sorszam,
                                 RendDatum = x.RendDatum,
                                 SzallCim = x.SzallCim,
                                 SzallDatum = x.SzallDatum,
                             };
            listBoxRendelések.DataSource = rendelesek.ToList();
            listBoxRendelések.DisplayMember = "RendDatum";
        }

        private void listBoxÜgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }

        private void listBoxRendelések_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sorszam = ((RendelesDetail)listBoxRendelések.SelectedItem).Sorszam;
            var rendtetel = from x in context.RendelesTetel
                            where x.Sorszam == sorszam
                            select new
                            {
                                Ár = x.Egysegar * x.Mennyiseg
                            };
            var összesen = (from x in rendtetel select x.Ár).Sum();
            textBoxÖssz.Text = összesen.ToString();
            textBoxDarab.Text = listBoxRendelések.Items.Count.ToString();
        }
    }

    public class RendelesDetail
    {
        public int Sorszam { get; set; }
        public DateTime? RendDatum { get; set; }
        public string SzallCim { get; set; }
        public DateTime? SzallDatum { get; set; }
    }
}
