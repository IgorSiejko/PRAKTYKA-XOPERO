using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
      

       static public string EncodeTo64(string toEncode)

        {
            byte[] toEncodeAsBytes

                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue

                  = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
           

        }
        static string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);

            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            static  string EncodeTo64(string toEncode)
            {
                byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
                string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
                return returnValue;
            }

            string myData = "text";
            string myDataEncoded = EncodeTo64(myData);
            MessageBox.Show(myDataEncoded);
      
        }
         private void button3_Click(object sender, EventArgs e)
        {
            static string DecodeFrom64(string encodedData)
             {
                 byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
                 string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
                 return returnValue;
             }

             string myData = "VGVzdA==";
             //string myData = "test"
             string myDataEncoded = EncodeTo64(myData);
             string myDataUnencoded = DecodeFrom64(myDataEncoded);

             MessageBox.Show(myDataUnencoded);
            

        }

     
    

       

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                
            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\xopero\Desktop\test.txt");
            //MessageBox.Show(text);
            string FileName = @"C: \Users\xopero\Desktop\test.txt";

          

        }

    }
}

