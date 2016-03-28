using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = this.Width;
            this.progressBar2.Minimum =0;
            this.progressBar2.Maximum = this.Height;
        }

      

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.progressBar1.Value = e.X;
            this.progressBar2.Value = e.Y;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }


    }
}
