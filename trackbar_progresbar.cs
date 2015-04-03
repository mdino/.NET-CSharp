using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 12) {
               
                progressBar1.Value = trackBar1.Value;
                progressBar2.Value = 24 -  trackBar1.Value;
            }

            if (trackBar1.Value > 12)
            {
                progressBar2.Value = trackBar1.Value;
                progressBar1.Value = 24 - trackBar1.Value;
            }


           
           


        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
