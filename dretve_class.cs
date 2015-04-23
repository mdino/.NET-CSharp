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

namespace zadatak_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static MyDisplay prva = new MyDisplay();
        static MyComm druga = new MyComm();


        Thread dretva1 = new Thread(new ThreadStart(prva.myThreadOne));
        Thread dretva2 = new Thread(new ThreadStart(druga.drugaDretva));


        private void button1_Click(object sender, EventArgs e)
        {
            dretva1.Start();
            dretva2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}





