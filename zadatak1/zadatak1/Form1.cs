using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           /* Class1 klasa1 = new Class1();
            klasa1.Forma();
            */

            Class1.Forma();
            int zbroj = 0;

            
            foreach (Form1 form in Application.OpenForms)
            {
                zbroj++;
                form.button1.Text = zbroj.ToString();
            }

            /*
            for (int i = 1; i < Application.OpenForms.Count; i++) {
                zbroj++;
                button1.Text = zbroj.ToString();
            }
             * */



        }
    }
}
