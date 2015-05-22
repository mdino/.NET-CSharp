using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dohvatiTimove();
        }

        public void dohvatiTimove()
        {
            System.ComponentModel.BindingList<Tim> listaTimova=null;
            using (var db = new studentiEntities()){
                listaTimova = new BindingList<Tim>( db.Tim.ToList());
            }
            dataGridView1.DataSource = listaTimova;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tim t = new Tim();
            t.OznakaTima = "test";
            t.OpisProjekta = "TEST";
            t.NazivProjekta = "test";
            t.Napomena = "test";
            using (var db = new studentiEntities())
            {
                db.Tim.Attach(t);
                db.Tim.Add(t);
                db.SaveChanges();
            }
            dohvatiTimove();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int pozicijaOdabranog = dataGridView1.CurrentCell.RowIndex;
                int idOdabranog = int.Parse(dataGridView1.Rows[pozicijaOdabranog].Cells[0].Value.ToString());

                System.ComponentModel.BindingList<Student> listaStudenata = null;
                using (var db = new studentiEntities())
                {
                    listaStudenata = new BindingList<Student>((
                        from s in db.Student
                        where s.TimId == idOdabranog
                        select s).ToList());
                }
                dataGridView2.DataSource = listaStudenata;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pozicijaOdabranog = dataGridView2.CurrentCell.RowIndex;
            int idOdabranog = int.Parse(dataGridView2.Rows[pozicijaOdabranog].Cells[0].Value.ToString());

            using (var db = new studentiEntities())
            {
                Student stud = (from t in db.Student
                           where t.Id == idOdabranog
                           select t).FirstOrDefault();
                db.Student.Remove(stud);
                db.SaveChanges();
            }
            dohvatiTimove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pozicijaOdabranog = dataGridView2.CurrentCell.RowIndex;
            int idOdabranog = int.Parse(dataGridView2.Rows[pozicijaOdabranog].Cells[0].Value.ToString());

            using (var db = new studentiEntities())
            {
                Student stud = (from t in db.Student
                                where t.Id == idOdabranog
                                select t).FirstOrDefault();
                stud.Prezime += "1";
                db.SaveChanges();
            }
            dohvatiTimove();
        }
    }
}
