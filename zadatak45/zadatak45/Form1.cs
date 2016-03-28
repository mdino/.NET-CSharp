using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popuni12();

        }

        private void popuni12() {
            listBox1.Items.Clear();
            ArrayList lista = new ArrayList();

            for (int i = 1; i <= 12; i++)
            {
                lista.Add(i);
            }

            listBox1.DataSource = lista;
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(listBox1.SelectedValue);

            int d = DateTime.DaysInMonth(2013, val);
            ArrayList mounth = new ArrayList();

            for (int i = 1; i < d; i++) 
            {
                mounth.Add(i);
            }
            listBox2.DataSource = mounth;
        }

       

       
    }
}
