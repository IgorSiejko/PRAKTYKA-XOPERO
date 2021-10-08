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
            /*   crt.CommandText =
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
                   crt.ExecuteNonQuery();*/
            crt.CommandText = "INSERT INTO Person(Name, LastName, Email, PhoneNumber) VALUES('" + Name1.Text + "','" + Lastname1.Text + "','" + Email1.Text + "','" + Phonenmbr1.Text + "');";
            try { crt.ExecuteNonQuery(); }
            catch (SQLiteException doppledata)
            {
                Console.WriteLine(doppledata.StackTrace);
                var w = doppledata.GetType();
                Console.WriteLine(w);
                MessageBox.Show("Number telefonu, lub E-mail zostały kiedyś wprowadzone. Spróbuj ponownie");
                Email1.Clear();
                Phonenmbr1.Clear();
            }
            crt.CommandText = "INSERT INTO Company(Product, NaKiedy, Adres, Cost) VALUES('" + Product.Text + "','" + When.Text + "','" + Adres3.Text + "','" + Cost.Text + "');";
            crt.ExecuteNonQuery();
            //crt.Parameters;
            /* try { crt.ExecuteNonQuery(); }
             catch(SQLiteException doppledata3)
             {
                 Console.WriteLine(doppledata3.StackTrace);
                 var w = doppledata3.GetType();
             }*/
            crt.CommandText = "INSERT INTO OrderData(Nazwa, Adres, NIP, REGON) VALUES('" + CompanyName.Text + "','" + Adres3.Text + "','" + NIP1.Text + "','" + REGON.Text + "');";
            crt.ExecuteNonQuery();
            /* try { crt.ExecuteNonQuery(); }
             catch (SQLiteException doppledata2)
             {
                 Console.WriteLine(doppledata2.StackTrace);
                 var w = doppledata2.GetType();
                 Console.WriteLine(w);
                 // MessageBox.Show("Nazwa,Regon, lub NIP zostały kiedyś wprowadzone, proszę spróbuj ponownie");
                 MessageBox.Show("Nazwa,Regon, lub NIP zostały kiedyś wprowadzone, proszę spróbuj ponownie");
                 REGON.Clear();
                 CompanyName.Clear();
                 NIP1.Clear();
             }*/
            /*            
            crt.CommandText = "DROP TABLE IF EXISTS OrderData";(Product, NaKiedy, Adres, Cost)
            crt.ExecuteNonQuery();
            crt.CommandText = "DROP TABLE IF EXISTS Company";
            crt.ExecuteNonQuery();
            crt.CommandText = "DROP TABLE IF EXISTS Person";
            crt.ExecuteNonQuery();
        }
        private void Clear1_Click(object sender, EventArgs e)
        {
            Name1.Clear();
            Adres1.Clear();
            Email1.Clear();
            Phonenmbr1.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //connection();
        }
        private void ConnSql_Click_1(object sender, EventArgs e)
        {
            connection();
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
        private void Lastname1_TextChanged(object sender, EventArgs e)
        {
        }
        private void ConnSql_Click(object sender, EventArgs e)
        {
            connection();
        }
        private void Clear1_Click(object sender, EventArgs e)
        {
            //company
            Name1.Clear();
            Lastname1.Clear();
            Email1.Clear();
            Phonenmbr1.Clear();
            //order
            //Person
        }
    }
}