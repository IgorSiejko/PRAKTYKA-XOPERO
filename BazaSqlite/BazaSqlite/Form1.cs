using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BazaSqlite
{
    public partial class ConnSQLite : Form
    {
        public ConnSQLite()
        {
            InitializeComponent();
        }
       
            public void connection()
            {
                string cs = @"URI=file:C:\Users\xopero\source\repos\BazaSqlite\BazaSqlite\test.db";
                using var con = new SQLiteConnection(cs);
                con.Open();
            using var crt = new SQLiteCommand(con);

            crt.CommandText =
                @"CREATE TABLE Person
            (
                ID   INTEGER,
                Name  TEXT,
                LastName  TEXT,
                Email TEXT UNIQUE,
                PhoneNumber   NUMERIC UNIQUE,
                PRIMARY KEY(ID AUTOINCREMENT)
            );";
                crt.ExecuteNonQuery();


                crt.CommandText =
                @"CREATE TABLE Company
            (
                ID  INTEGER UNIQUE,
                Nazwa   TEXT UNIQUE,
                Adres   TEXT,
                NIP INTEGER UNIQUE,
                REGON   INTEGER UNIQUE,
                PRIMARY KEY(ID AUTOINCREMENT)
            );";
                crt.ExecuteNonQuery();

                crt.CommandText =
                @"CREATE TABLE OrderData 
            (
                ID INTEGER UNIQUE,
	            Product TEXT,
                NaKiedy TEXT,
	            Adres TEXT,
                Cost    NUMERIC,
	            PRIMARY KEY(ID AUTOINCREMENT)
            );";
                crt.ExecuteNonQuery();

            crt.CommandText = "INSERT INTO Person(Name, LastName, Email, PhoneNumber) VALUES('@dwa','@trzu','@cztery','@piec')";
            crt.ExecuteNonQuery();
            crt.CommandText = "INSERT INTO Company(Nazwa, Adres, NIP, REGON) VALUES('@dwa','@trzu','@cztery','@piec')";
            crt.ExecuteNonQuery();
            crt.CommandText = "INSERT INTO OrderData(Product, NaKiedy, Adres, Cost) VALUES('@dwa', '@trzu', '@cztery', '@piec')";
            crt.ExecuteNonQuery();
            /*            
            crt.CommandText = "DROP TABLE IF EXISTS OrderData";
            crt.ExecuteNonQuery();
            crt.CommandText = "DROP TABLE IF EXISTS Company";
            crt.ExecuteNonQuery();
            crt.CommandText = "DROP TABLE IF EXISTS Person";
            crt.ExecuteNonQuery();*/

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //connection();
        }
        private void ConnSql_Click_1(object sender, EventArgs e)
        {
        }
        static void ConnSql_Click(object sender, EventArgs e)
            {
                /* SQLiteConnection sqlite_conn;
                 SQLiteConnection sqlite_cmd;
                 SQLiteDataReader sqlite_datereader;
                */
                //crt.CommandText = "INSERT INTO Person(Name, LastName, Email, PhoneNumber) VALUES()";
         
            }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }
    }
}