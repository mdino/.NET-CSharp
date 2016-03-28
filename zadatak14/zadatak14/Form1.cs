using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 20* 60* 60 je 20 puta 360 a to je 20h
            long a = 20 * 60 * 60 + 45 * 60;
            long b = DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            label5.Text = (a - b).ToString() + "sec";
            

            //vrijeme sada
            
            string vrijeme = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            label3.Text = vrijeme;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
