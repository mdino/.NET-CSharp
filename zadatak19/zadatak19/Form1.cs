using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String f1 = textBox1.Text;
            String f2 = textBox2.Text;

            int n1, n2;
            n1 = n2 = 0;

            try {
            n1 = Convert.ToInt32(f1);
            n2 = Convert.ToInt32(f2);
            }
            catch (Exception) {
               MessageBox.Show("Format ne valja");
            }

            if (n2 == 0)
            {
                MessageBox.Show("Nula");
            }

            int retultat;
            retultat = n1 / n2;
            textBox3.Text = retultat.ToString();
            
        }
    }
}
