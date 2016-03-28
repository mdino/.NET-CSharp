using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak46
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
   
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            Pravokutnik newpravokutnik = new Pravokutnik(a,b);

            textBox3.Text = newpravokutnik.izracunajPovrsinu().ToString();
            textBox4.Text = newpravokutnik.izracunajOpseg().ToString();
            textBox5.Text = newpravokutnik.IzracunajDijagonalu().ToString();

        }
    }
}
