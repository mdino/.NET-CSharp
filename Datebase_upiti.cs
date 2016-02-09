using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        

        private void button1_Click(object sender, EventArgs e)
        {
            string OznakaTima = textBox2.Text;
            string NazivProjekta = textBox3.Text;
            string OpisProjekta = "aa";
            string Napomena = "bb";
            string sqlUpit = "";

            sqlUpit = "INSERT INTO Tim (Id, OznakaTima, NazivProjekta, OpisProjekta, Napomena) VALUES (null, '" + OznakaTima + "','" + NazivProjekta + "','" + OpisProjekta + "','" + Napomena + "')";

            DataClass klasa = new DataClass();
            //klasa.selectQuery(sqlUpit);
            klasa.IzvrsiUpit(sqlUpit);

 
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string sql= "";
            sql = "SELECT OznakaTima, NazivProjekta FROM Tim WHERE Id=1";
            DataClass klasa = new DataClass();
            SQLiteDataReader reader = klasa.Upit(sql);

            List<Object> list = new List<Object>();

            while (reader.Read())
            {
                list.Add(reader.GetString(0) + reader.GetString(1));

                label1.Text = reader.GetString(0) + reader.GetString(1);
            }
            reader.Close();
           
            foreach (var s in list) { 
            textBox3.Text= s.ToString();
            }
        }
    }
}
