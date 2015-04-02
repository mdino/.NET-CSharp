//opcijama open i exit. Na exit se zatvara aplikacija, a na open se otvara nova instanca prozora glavne forme 
kao MDI dijete postojeće glavne forme.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.MdiParent = this;
            form.Show();
        }
    }
}
