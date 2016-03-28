using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string slovo = textBox1.Text;

            slovo = slovo.Replace("a","b");

            textBox1.Text = slovo;

            textBox1.Select(slovo.Length, 0);
        }
    }
}
