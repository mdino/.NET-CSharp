using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size - 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size + 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.label1.Text= "";

            for (int i = 0; i < 5; i++)
            {

                label1.Text += (char)r.Next(0, 122);
  
            }

            
        }
    }
}
