using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 0;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sec = Convert.ToInt32(textBox1.Text);
            timer1.Interval = 1000;
            timer1.Start();
            button1.Text = sec.ToString();
            count = sec;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            button1.Text = count.ToString();

            if (count == 0)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

    }
}
