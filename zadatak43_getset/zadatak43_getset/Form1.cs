using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak43_getset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a 
        { 
            get {return int.Parse(textBox1.Text);}
            set { a = value; }
        }

        private int b 
        {
            get {return int.Parse(textBox2.Text);}
            set { b = value; }
        }

        private int suma {
            get { return a + b; }
            set { suma = value; }
        }

        private int oduzmi {
            get { return a - b; }
            set { oduzmi = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(suma.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(oduzmi.ToString());

        }

    }
}
