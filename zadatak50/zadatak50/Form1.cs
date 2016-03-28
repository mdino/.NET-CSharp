using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newbutton_Click(object sender, EventArgs e) 
        {
           // Button button = (Button) sender;
            Button button = sender as Button;
            MessageBox.Show(button.Location.X.ToString() + "; " + button.Location.Y.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.textBox1.Text);
            Random r = new Random();

            for (int i = 0; i < x; i++) 
            {
                Button newbutton = new Button();

                int a = r.Next(0,this.Width -newbutton.Width);
                int b = r.Next(0, this.Height - newbutton.Height);
                newbutton.Text = r.Next().ToString();
                newbutton.Location = new Point(a, b);
                newbutton.Click += new EventHandler(this.newbutton_Click);
                this.Controls.Add(newbutton);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
