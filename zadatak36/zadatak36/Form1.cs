using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Maximum = 12;
            this.numericUpDown2.Minimum = 1;
            this.numericUpDown2.Maximum = 12;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prvi = Convert.ToInt32(numericUpDown1.Value);
            int drugi = Convert.ToInt32(numericUpDown2.Value);
            label1.Text = "";

            for (int i = prvi; i < drugi; i++)
            {
                label1.Text += i.ToString() + ",";
            }
        }
    }
}
