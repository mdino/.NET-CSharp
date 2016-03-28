using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++) {
                ProgressBar newProgressBar = new ProgressBar();
                newProgressBar.Minimum=0;
                newProgressBar.Maximum=100;
                newProgressBar.Location = new Point(0, 30* (i+1));
                this.Controls.Add(newProgressBar);
            }

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            
            foreach(Control baza in this.Controls)
            {
                if (baza.GetType().Name.Equals("ProgressBar"))
                {
                    ProgressBar p = (ProgressBar)baza;
                    p.Value = r.Next(0, 100);
                
                }
            
            }
        }
    }
}
