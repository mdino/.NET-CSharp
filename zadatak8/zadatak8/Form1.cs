using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = textBox3.Text;


            c = c.Replace(a, b);

            textBox3.Text = c;

            textBox3.Select(textBox3.TextLength, 0);


        }
    }
}
