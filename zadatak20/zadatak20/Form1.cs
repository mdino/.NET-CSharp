using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //21.12. - 21.3 - zima
            //21.3 - 21.6. - proljece
            //21.6 - 23.9 - ljeto
            //23.9 - 21.12. - jesen

            DateTime d = dateTimePicker1.Value;


            if ((d.Month >= 1 && d.Day >= 1) && d.Month<=3)
                label1.Text = "Zima";

           if ((d.Month >= 3 && d.Day >= 21) && d.Month<=6)
                label1.Text = "Proljeće";

           if ((d.Month >= 6 && d.Day >= 21) && d.Month <=9)
                label1.Text = "Ljeto";

            if ((d.Month >= 9 && d.Day >= 23) && d.Month<=12)
                label1.Text = "Jesen";

            if (d.Month >= 12 && d.Day >= 21)
                label1.Text = "Zima";




        }
    }
}
