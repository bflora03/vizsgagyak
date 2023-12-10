using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsgagyak
{
    public partial class UjUgyfel : Form
    {
        public UjUgyfel()
        {
            InitializeComponent();
        }

        private void UjUgyfel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private bool CheckNev(string nev)
        {
            Regex regex = new Regex("^[A-Z]\\w+( [A-Z]\\w+)+$");
            return regex.IsMatch(nev);
        }

        private bool CheckEmpty(string adat)
        {
            return !string.IsNullOrEmpty(adat);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckNev(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Töltse ki helyesen a mezőt!");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Ne hagyja üresen!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox6.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox6, "Ne hagyja üresen!");
            }
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox6, "");
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox5, "Ne hagyja üresen!");
            }
        }

        private void textBox5_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox5, "");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox4.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "Ne hagyja üresen!");
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox4, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Ne hagyja üresen!");
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
