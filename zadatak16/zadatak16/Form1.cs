using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label3.Text = (DateTime.Now.DayOfWeek).ToString();

            int broj = DayOfWeek.Friday - DateTime.Now.DayOfWeek;

            label4.Text = broj.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
