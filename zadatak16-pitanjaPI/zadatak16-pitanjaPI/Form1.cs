using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak16_pitanjaPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;

            label1.Text= student.ispis(ime, prezime);

            label2.Text= redovitistudent.ispis(ime, prezime);

            student klasa = new student();
            label3.Text = klasa.ispis2(ime,prezime);

            redovitistudent klasa2 = new redovitistudent();
            label4.Text = klasa2.ispis2(ime, prezime);

        }
    }
}
