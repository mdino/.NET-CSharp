using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLabel();
        }

        private void setLabel()
        {
            int x= (this.Width/2) - (this.label1.Width/2);
            int y= (this.Height/2) - (this.label1.Width/2)-25;
            this.label1.Location = new Point(x, y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {


            int MiddleX = (this.Width / 2) - e.X;
            int MiddleY = ((this.Height / 2) - 25) - e.Y;



            if (MiddleX > 0 && MiddleY > 0)
            {
                label1.Text = "SZ";
                this.BackColor = Color.Green;
            }

            if (MiddleX < 0 && MiddleY > 0)
            {
                label1.Text = "SI";
                this.BackColor = Color.Blue;

            }

            if (MiddleX > 0 && MiddleY < 0)
            {
                label1.Text = "JZ";
                this.BackColor = Color.Red;

            }

            if (MiddleX < 0 && MiddleY < 0)
            {
                label1.Text = "JI";
                this.BackColor = Color.Yellow;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setLabel();
        }

    }
}
