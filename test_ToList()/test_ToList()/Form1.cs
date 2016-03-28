using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_ToList__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> lista = textBox1.Text.ToList<char>();

            label1.Text = "";
            foreach (char c in lista) {
                int broj = lista.FindAll(letter => letter == c).Count; // potrazi sva ista slova
                label1.Text += c.ToString() + '=' + broj.ToString();

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string a = textBox1.Text;
            

        }
    }
}
}
