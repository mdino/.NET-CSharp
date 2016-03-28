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

namespace zadatak29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] l = new Label[7];
            l[0] = label1;
            l[1] = label2;
            l[2] = label3;
            l[3] = label4;
            l[4] = label5;
            l[5] = label6;
            l[6] = label7;



            Random r = new Random();

            int num;
            List<int> lista = new List<int>();
            while (lista.Count != 7) {
                    num = r.Next(1, 38);
                    if (!lista.Contains(num))
                    {
                        lista.Add(num);
                        l[lista.Count - 1].Text = num.ToString();

                        if (num < 20) l[lista.Count - 1].ForeColor = Color.Green;
                        else l[lista.Count - 1].ForeColor = Color.Red;

                    }
            }

  
        }
    }
}
