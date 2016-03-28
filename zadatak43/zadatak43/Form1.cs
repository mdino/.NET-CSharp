using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak43
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
          

        }

        private int broj1 =0;
        private int broj2 =0;

        private int br1(int a){
            return a = int.Parse(textBox1.Text);
        }

        private int br2(int b) {
            return b = int.Parse(textBox2.Text);
        }

        public int suma(int a, int b){
            return br1(a)+br2(b);
        }

        public int oduzmi (int a,int b){
            return br1(a) - br2(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((suma(broj1, broj2)).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show((oduzmi(broj1, broj2)).ToString());

        }


        
    }
}


