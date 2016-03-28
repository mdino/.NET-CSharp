using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int x = this.Width / 2; // sredina
            int y = this.Height / 2; // sredina

            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                Label newl = new Label();
                int num = r.Next(0,1000);

                if (num > 500 && num % 2 != 0)
                {
                    newl.Text = num.ToString();
                    int a = r.Next(0, x); // od nula do sredine na x osi
                    int b = r.Next(0, y); // gornja polovica
                    newl.Location = new Point(a, b); // lijeva gornja polovica
                }

                else if (num > 500 && num % 2 == 0)
                {
                    newl.Text = num.ToString();
                    int a = r.Next(x, this.Width); // od sredine pa do kraja desne polovice
                    int b = r.Next(0, y);
                    newl.Location = new Point(a, b); // desna gornja polovica
                }
                

                else if (num < 500 && num % 2 != 0)
                {
                    newl.Text = num.ToString();
                    int a = r.Next(0, x); // lijeva polovica
                    int b = r.Next(y, this.Height); // donja polovica
                    newl.Location = new Point(a, b);
                }

                else if (num < 500 && num % 2 == 0) 
                {
                    newl.Text = num.ToString();
                    int a = r.Next(x, this.Width); // lijeva polovica
                    int b = r.Next(y, this.Height); // donja polovica
                    newl.Location = new Point(a, b);
                
                }






                this.Controls.Add(newl);

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Width / 2;
            int y = this.Height / 2;
        }

      
    }
}
