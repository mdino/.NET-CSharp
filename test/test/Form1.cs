using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar2.Maximum = 100;
            Random r = new Random();

            foreach (Control b in this.Controls) {
                if (b.GetType().Name.Equals("TrackBar")) {
                    TrackBar p = (TrackBar)b;
                    p.Value= r.Next(0, 100);


                }
            
            }
        }
    }
}
