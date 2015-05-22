using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1_EvidencijaStudenataX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dohvatiAktivnost();
        }

        public void dohvatiAktivnost() 
       {
  
           System.ComponentModel.BindingList<TipAktivnosti> listaTipova=null;
           using (var db = new EvidencijaStudenataEntities4())
           { 
               listaTipova = new BindingList<TipAktivnosti>( db.TipoviAktivnosti.ToList()); 
            } 
            dataGridView1.DataSource = listaTipova; 

        } 


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipAktivnosti t = new TipAktivnosti();

            t.Tip = textBox1.Text;
   
            using (var db = new EvidencijaStudenataEntities4())
            {
                db.TipoviAktivnosti.Attach(t);
                db.TipoviAktivnosti.Add(t);
                db.SaveChanges();
            }
             dohvatiAktivnost(); 
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pozicijaOdabranog = dataGridView1.CurrentCell.RowIndex;
            int idOdabranog = int.Parse(dataGridView1.Rows[pozicijaOdabranog].Cells[0].Value.ToString());

            using (var db = new EvidencijaStudenataEntities4())
            {
               TipAktivnosti tipAktv = (from t in db.TipoviAktivnosti
                                where t.Id == idOdabranog
                                select t).FirstOrDefault();
               db.TipoviAktivnosti.Remove(tipAktv);
                db.SaveChanges();
            }
            dohvatiAktivnost();
        } 


        }
    }

