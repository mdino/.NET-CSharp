using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak32
{
    public partial class Form1 : Form
    {

        private int R 
        {
            get { return trackBar1.Value; }
        }

        private int G
        {
            get { return trackBar2.Value; }
        }

        private int B
        {
            get { return trackBar3.Value; }
        }


        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 250;
            trackBar1.Minimum = 0; //.....
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(R, G, B);

        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(R, G, B);

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(R, G, B);

        }
    }
}
