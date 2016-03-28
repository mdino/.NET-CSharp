using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u1 = textBox1.Text;
            string u2 = textBox2.Text;
            string u3 = textBox3.Text;

            int R,G,B;
            R = G = B = 0;

            try {
                R = Convert.ToInt32(u1);
                G = Convert.ToInt32(u2);
                B = Convert.ToInt32(u3); 
            }
            catch {
                MessageBox.Show("Krivi unos");
            }


            this.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
