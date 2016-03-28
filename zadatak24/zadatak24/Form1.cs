using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unos1 = textBox1.Text;
            string unos2 = textBox2.Text;

            string[] s1 = unos1.Split(',');
            string[] s2 = unos2.Split(',');

            List<string> lista = new List<string>();
            lista.AddRange(s2);

            foreach (string item in s1) {
                if (lista.Contains(item)) {
                    this.textBox3.Text = textBox3.Text + item + ',';
                }
            
            }        
        }
    }
}
