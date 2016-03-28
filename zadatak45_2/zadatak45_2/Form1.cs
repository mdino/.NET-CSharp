using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak45_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < 13; i++)
            {
                this.listBox1.Items.Add(i);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int val = (int)listBox1.SelectedItem;
            int d = DateTime.DaysInMonth(2016, val);

            for (int i = 1; i < d; i++)
            {
                this.listBox2.Items.Add(i);
            }
        }

       
      
    }
}
