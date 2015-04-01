//1. potrebno je napravit aplikaciju pri kojoj se pritiskom na tipku otvara svaki
puta nova forma i u natpisu tipke neka pise broj instanci glavne forme


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {

        int zbroj=0;


        public Form1()
        {
            InitializeComponent();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Form1 newForm = new Form1();
            newForm.Show();
            

            for (int i = 0; i < Application.OpenForms.Count; i++) {

                zbroj++;
                newForm.button1.Text = zbroj.ToString();
               
                
            }
            

            

        }
    }
}
