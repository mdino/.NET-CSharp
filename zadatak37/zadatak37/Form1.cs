using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T) {

                Random r = new Random();
                int x = r.Next(0, this.Width - this.textBox1.Width);
                int y = r.Next(0, this.Height - this.textBox1.Height);
                this.textBox1.Location = new Point(x, y);
            }
        }

       
    }
}
