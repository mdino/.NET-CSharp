using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak2
{
    public partial class Form1 : Form
    {
        int zbroj;
        int broj;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zbroj++;
            label1.Text = zbroj.ToString();
            if (broj == zbroj) {
                zbroj = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            broj = Convert.ToInt32(textBox1.Text);

        }
    }
}
