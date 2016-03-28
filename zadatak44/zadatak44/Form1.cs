using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int x = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < x; i++)
            {
                Label label1 = new Label();
                label1.Location = new Point(r.Next(0,this.Width - label1.Width - 10), r.Next(0,this.Height - label1.Height - 30));
                label1.Text = r.Next(0, 255).ToString();
                this.Controls.Add(label1);
            
            }

        
        }
    }
}
