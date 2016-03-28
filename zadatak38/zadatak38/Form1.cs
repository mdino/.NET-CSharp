using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        bool timer=true;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            if (timer==true) {
                timer1.Start();
                timer = false;
            }
            else {
                timer1.Stop();
                timer = true;
            }

        }

        private void mjenjaj() {

            Label[] l = new Label[5];
            l[0] = label1;
            l[1] = label2;
            l[2] = label3;
            l[3] = label4;
            l[4] = label5;

            Random r = new Random();



            for (int i = 0; i < 5; i++)
            {
                int num = r.Next();
                int x = r.Next(0, this.Width);
                int y = r.Next(0, this.Height);
                l[i].Location = new Point(x, y);
                l[i].Text = num.ToString();
            }
        }

      
       
    }
}
