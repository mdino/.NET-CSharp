using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak49
{
    public partial class Form1 : Form
    {
        struct CharCount
        {
            char c;
            int count;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string printOut = "";
            List<char> sentence = this.textBox1.Text.ToList<char>();
            List<char> chars = new List<char>();
            foreach (char c in sentence)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                }

            }

            foreach (char c in chars)
            {
                int count = sentence.FindAll(letter => letter == c).Count;
                printOut += c.ToString() + '=' + count.ToString();
                
            }
            MessageBox.Show(printOut);
        }



        
    }
}
