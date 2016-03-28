using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();

            if (i % 2 == 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
                label1.ForeColor = Color.Black;

            if (i > 10) {
                WindowState = FormWindowState.Maximized;
            }
        }
        
    }
}
