using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Lozinka nije jednaka");
            }

            string a = textBox1.Text;
            string b = textBox2.Text;

            if (a.Length < 5 && b.Length < 5)
            {
                MessageBox.Show("Premalo znakova");

            }

            int brojac = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsUpper(a[i]))
                {
                    brojac++;
                }
            }

            if (brojac < 3)
            {
                MessageBox.Show("Nema dovoljno velikih slova!");

            }

            if (!a.Contains('#') || !a.Contains('$'))
            {
                MessageBox.Show("Niste koristili znakove iz skupa");
            }




        }
    }
}
