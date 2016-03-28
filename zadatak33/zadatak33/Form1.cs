using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak33
{
    public partial class Form1 : Form
    {
        private int A { get; set; }
        private int B { get; set; }
        private int C { get; set; }

        private int suma
        {
            get { return A + B; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A= Convert.ToInt32(textBox1.Text);
            B= Convert.ToInt32(textBox2.Text); 
            C= Convert.ToInt32(textBox3.Text);

            if (suma % C == 0) {
                this.button1.Text = "Preskoci";
            }
            else
            this.button1.Text = suma.ToString();
        }
    }
}
