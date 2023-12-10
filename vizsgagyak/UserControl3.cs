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
    public partial class UserControl3 : UserControl
    {
        Models.RendelesContext context = new Models.RendelesContext();
        public UserControl3()
        {
            InitializeComponent();
            UgyfelSzures();
            RendelesListazas();
            TetelSzures();
        }

        public void UgyfelSzures()
        {
            var uf = from x in context.Ugyfel where x.Nev.Contains(textBoxUgyfelSzuro.Text) select x;
            listBoxUgyfelek.DataSource = uf.ToList();
            listBoxUgyfelek.DisplayMember = "Nev";
        }
        private void textBoxUgyfelSzuro_TextChanged(object sender, EventArgs e)
        {
            UgyfelSzures();
        }
        public void RendelesListazas()
        {
            var selugyfel = ((Ugyfel)listBoxUgyfelek.SelectedItem).Login;
            var rendelesek = from x in context.Rendeles
                             where x.Login == selugyfel
                             select x;
            listBoxSorszamok.DataSource = rendelesek.ToList();
            listBoxSorszamok.DisplayMember = "Sorszam";
        }

        private void listBoxUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }
        public void TetelSzures()
        {
            var tetel = from x in context.Termek
                        where x.Megnevezes.Contains(textBoxTetelSzuro.Text)
                        select x;
            listBoxTetelek.DataSource = tetel.ToList();
            listBoxTetelek.DisplayMember = "Megnevezes";
        }

        private void textBoxTetelSzuro_TextChanged(object sender, EventArgs e)
        {
            TetelSzures();
        }

        private void listBoxTetelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seltetel = (Termek)listBoxTetelek.SelectedItem;
            var megyseg = (from x in context.Termek where x.Termekkod == seltetel.Termekkod select x).FirstOrDefault();
            label1.Text = megyseg.Megys.ToString();
        }

        public void TételListázás()
        {
            var selsorszam = ((Rendeles)listBoxSorszamok.SelectedItem).Sorszam;
            var tetelek = from x in context.RendelesTetel
                          where x.Sorszam == selsorszam
                          select new TetelDetail
                          {
                              Termékkód = x.Termekkod,
                              Megnevezés = x.TermekkodNavigation.Megnevezes,
                              Egységár = x.Egysegar,
                              Mennyiség = x.Mennyiseg,
                              Megység = x.TermekkodNavigation.Megys
                          };
            tetelDetailBindingSource.DataSource = tetelek.ToList();
        }

        private void listBoxSorszamok_SelectedIndexChanged(object sender, EventArgs e)
        {
            TételListázás();
        }

        private void buttonPlusz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan hozzáadja a tételt?", "Tétel hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RendelesTetel rt = new RendelesTetel();
                rt.Sorszam = ((Rendeles)listBoxSorszamok.SelectedItem).Sorszam;
                rt.Termekkod = ((Termek)listBoxTetelek.SelectedItem).Termekkod;

                double m;
                if (double.TryParse(textBox3.Text, out m))
                {
                    rt.Mennyiseg = m;
                }
                double ar;
                if (double.TryParse(textBox4.Text, out ar))
                {
                    rt.Egysegar = ar;
                }

                context.RendelesTetel.Add(rt);
                context.SaveChanges();
                TételListázás();
            }
        }

        private void buttonMinusz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan törli a tételt?", "Tétel törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var seltetel = ((TetelDetail)tetelDetailBindingSource.Current).Termékkód;
                var törlendő = (from x in context.RendelesTetel
                                where x.Termekkod == seltetel
                                select x).FirstOrDefault();
                context.RendelesTetel.Remove(törlendő);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
                
                TételListázás();
            }
        }
    }

    public class TetelDetail
    {
        public string Termékkód { get; set; }
        public string Megnevezés { get; set; }
        public double? Egységár { get; set; }
        public double Mennyiség { get; set; }
        public string Megység { get; set; }
    }
}
