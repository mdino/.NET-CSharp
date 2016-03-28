using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int broj {
            get { return Convert.ToInt32(textBox1.Text); }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0, ";

            int a = 0;
            int b = 0;
            int c = 1;

            for (int i = 0; i < broj; i++) {
                label1.Text += c.ToString() + ", ";

                a = b;
                b = c;
                c = a + b;

            }


                
            }
            
        }
    }

