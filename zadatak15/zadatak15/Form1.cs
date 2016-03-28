using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int godina = Convert.ToInt32(textBox1.Text);

            DateTime d = new DateTime(godina, 1, 1); // (godina, mjesec, dan), mi trebamo pocetak godine 

            int petak = 0;

            while (d.Year != (godina + 1))
            {  // dok je pocetak godine razlicit od kraja godine tj godina+1

                if (d.Day == 13 && d.DayOfWeek == DayOfWeek.Friday) petak++;
                d = d.AddDays(1);  // povecavamo dan za jedan
            }

            label1.Text = petak.ToString();
             
        }
    }
}
