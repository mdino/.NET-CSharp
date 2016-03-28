using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak30
{
    public partial class Form1 : Form
    {
        List<int> lista = new List<int>();
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < 13; i++)
            {
                lista.Add(i);
            }

            comboBox1.DataSource = lista;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mjesec = (int)comboBox1.SelectedValue;
            DateTime d = new DateTime(2016, mjesec, 1);
            monthCalendar1.SetDate(d);

        }
    }
}
