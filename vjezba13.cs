using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (Control item in this.Controls) {

                if (item.GetType() == typeof(Button))
                {

                    item.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                    int width, height;
                    width = r.Next(0, 255);
                    height=r.Next(0,255);
                    item.Size = new Size(width, height);

                }

                if (item.GetType() == typeof(Label))
                {
                    item.Location = new Point(r.Next(0, this.Height), r.Next(0, this.Width));

                }

                if (item.GetType() == typeof(TextBox)) {
                    item.ForeColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                    int a;
                    a = r.Next(0, 255);
                 
                    textBox1.Text=a.ToString();
                    textBox2.Text = a.ToString();

                }

               
            }
        }
    }
}
