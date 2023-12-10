using Microsoft.Identity.Client;
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
    public partial class UserControl2 : UserControl
    {
        Models.RendelesContext context = new Models.RendelesContext();
        public UserControl2()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Ugyfel.ToList();
        }

        private void buttonUjUgyfel_Click(object sender, EventArgs e)
        {
            UjUgyfel uf = new UjUgyfel();
            if (uf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Ugyfel ugyfel = new Ugyfel();
            {
                ugyfel.Nev = uf.textBox1.Text;
                ugyfel.Login = uf.textBox2.Text;
                ugyfel.Email = uf.textBox6.Text;
                ugyfel.Szulev = Convert.ToInt32(uf.textBox3.Text);
                ugyfel.Cim = uf.textBox5.Text;
                ugyfel.Nem = uf.textBox4.Text;
            }
            context.Ugyfel.Add(ugyfel);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Nem sikerült az adatbázist elmenteni a következő hiba miatt: {ex.InnerException.Message}");
            }
        }
    }


}
