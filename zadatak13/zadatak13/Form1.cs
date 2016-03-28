using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // potrebno za arrylist

namespace zadatak13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unos = textBox1.Text;

            string[] nums = unos.Split(','); // koristi se za split stringova po zarezu

            ArrayList list = new ArrayList();
            
            foreach (string n in nums) list.Add(n);
            list.Sort();
            string novielem = "";
            foreach (string sortirani in list) {
                novielem += sortirani.ToString() + ",";
            }
            textBox1.Text = novielem;

            /*
            foreach (var n in nums) 
            { // kreci se kroz polje nums te dodaj u listu svaki element iz  tog polja
                list.Add(Convert.ToInt32(n));
            }

            list.Sort(); // sortiraj elemente u listi 

            string newstr = "";

            foreach (var l in list)
            {//
                int num = (int)l;
                newstr = newstr + num.ToString() + ',';
            }

            textBox1.Text = newstr;
            */
        }
    }
}
