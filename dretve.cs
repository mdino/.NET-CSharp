using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace zadatak60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread dretva = new Thread(new ThreadStart(dretvica));
            dretva.Start();
             
        }

        public void dretvica() {

            Random rand = new Random();
            int broj = rand.Next(1, 10);
            MessageBox.Show(DateTime.Now.ToString());
            Thread.Sleep(broj*1000);
            MessageBox.Show(DateTime.Now.ToString());
        
        
        
        }

    }
}
