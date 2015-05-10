using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data.SQLite;
using System.Data.Common;

namespace Lab_2_4_EvidencijaStudenata
{
    class DB
    {
        private static DB instance;
        private string connectionString;
        private SQLiteConnection connection;

        public static DB Instance {

            get { if (instance == null) { instance = new DB(); } return instance; }
        
 
        }

        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; } 
            private set { connectionString = value; } 
        } 
        public SQLiteConnection Connection //Konekcija prema bazi 
        {
            get { return connection; } 
            private set { connection = value; } 
        }

        private DB() //Konstruktor klase
        {
            ConnectionString = @"Data Source= C:\Users\Dino\Desktop\LAB-master\Lab_2_4_EvidencijaStudenata\Baza\EvidencijaStudenataPI.db3";
            Connection = new SQLiteConnection(ConnectionString); 
            Connection.Open(); 
        } 
        
        ~DB() //Destruktor klase 
        { 
            Connection.Close(); 
            Connection = null; 
        }

        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.

        public DbDataReader DohvatiDataReader(string sqlUpit) 
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection); 
            return command.ExecuteReader(); 
        }

        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
     
        public object DohvatiVrijednost(string sqlUpit) { 
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection); 
            return command.ExecuteScalar(); 
        }

        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// 
        public int IzvrsiUpit(string sqlUpit) { 
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery(); 
        }

    }
}
