using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak23
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            button1.Text = i.ToString();

            if (i % 10 == 0) this.BackColor = Color.Red;
            else BackColor = Color.Green;
        }
    }
}
