// korisnik unosi neki broj n u textbox te pritiskom na button se ispisuje u labelu n puta random brojevi zatim se racuna srednja vrijednost

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labosi_sacic
{
    public partial class Form1 : Form
    {
        int broj;
        int ispis = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            broj =Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //za brisanje listboxa:
           // listbox1.Items.Clear();

            // za unos broja iz tekstboxa:
            //listbox1.Items.Add(this.textBox1.Text);
            Random brojevi = new Random();
            
            for (int i = 0; i < broj; i++) {
                ispis=brojevi.Next(0, 259);
                listbox1.Items.Add(ispis);
                ispis += ispis;

            }
            int srednja= ispis/broj;

            textBox2.Text = srednja.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
