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
    class DataClass
    {
        private SQLiteConnection sqlite;
        private string connectionString;
        DataTable dt = new DataTable();


        public DataClass()
        {
           connectionString = @"Data Source= \\psf\Home\Documents\pi\adonet\EvidencijaStudenataPI.db3";
           sqlite = new SQLiteConnection(connectionString);
           sqlite.Open();
        }
        
        ~DataClass()          //Destruktor klase
        {
         sqlite.Close();
         sqlite = null;
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, sqlite);
            return command.ExecuteNonQuery();
        }

        public SQLiteDataReader Upit(string query) 
        {

        SQLiteCommand command = new SQLiteCommand(query, sqlite);
        return command.ExecuteReader();
        }

    }
}
