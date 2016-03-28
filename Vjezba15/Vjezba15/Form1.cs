using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string godina = textBox1.Text;

            int year = Convert.ToInt32(godina);

            int end_year = year + 1;

            DateTime d = new DateTime(year, 1, 1); // datetime (godina,mjesec,dan);

            int pogodak = 0;

            while (d.Year != end_year) {
                if (d.Day == 13 && d.DayOfWeek == DayOfWeek.Friday) ++pogodak;
            }

            d = d.AddDays(1);
            label1.Text = pogodak.ToString();
        }
    }
}
