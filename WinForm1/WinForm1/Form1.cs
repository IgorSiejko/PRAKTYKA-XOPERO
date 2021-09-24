using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
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

        //INPUT NA BASE 64-Sprawne
        //
        //
                private void button1_Click(object sender, EventArgs e)
                {
                    static string EncodeTo64(string toEncode)
                    {
                        byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
                        string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
                        return returnValue;
                    }
                    string myData = textBox1.Text;
                    string myDataEncoded = EncodeTo64(myData);
                    if (String.IsNullOrEmpty(myData))
                    {
                        MessageBox.Show("Wypełnij Pole!");
                    }
                    else
                    {
                        textBox2.Text = myDataEncoded;
                    }
                }
                private void CopyButton1_Click(object sender, EventArgs e)
                {
                    if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Wypełnij pole, aby skopiować");
                    }
                    else
                    {
                        Clipboard.SetText(textBox2.Text);
                    }
                }
                private void CopyButton2_Click(object sender, EventArgs e)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
          //KONIEC INPUT NA 64
         //
        //


          //BASE 64 NA INPUT-sprawne
         //
        //
        private void button3_Click(object sender, EventArgs e)
        {
            string myData = TextBoxToInput.Text;
            string test = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(myData));

            //string myDataEncoded = EncodeTo64(myData);
            //string myDataUnencoded = DecodeFrom64(myDataEncoded);
            if (String.IsNullOrEmpty(myData))
            {
                MessageBox.Show("Wypełnij Pole!");
            }
            else
            {
                TextBoxToInput2.Text = test;
            }
        }
        
         private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxToInput2.Text))
            {
                MessageBox.Show("Wypełnij pole, aby skopiować");
            }
            else
            {
                Clipboard.SetText(TextBoxToInput2.Text);
            }

        }
        private void ClearButton2_Click_1(object sender, EventArgs e)
        {
            TextBoxToInput.Clear();
            TextBoxToInput2.Clear();
        }
          //BASE 64 NA INPUT
         //
        //




        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\xopero\Desktop\test.txt";

            

         /*  if(File.Exists(path))
             {
                 MessageBox.Show("plik już istnieje");
             }
             else
             {
         */
          
                 // Open the file to read from.
                 using (StreamReader sr = File.OpenText(path))
                 {
                     string s = "";
                     while ((s = sr.ReadLine()) != null)
                     {
                         Console.WriteLine(s);
                         MessageBox.Show(s);
                     }
                 }
            
            

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
            //zmienna, która zawiera ścieżkę, w której zapisze się plik i jaki będzie miał format oraz nazwę
            string path = @"C:\Users\xopero\Desktop\test.txt";
            string text1 = textBox9.Text;
            string text2 = textBox10.Text;
          
            string info1="Wpisana Wartość: ";
            string info2="  Zakodowana Wiadomość:";
          
                //Tworzy plik i nadaje mu treść
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(info1+text1+info1+text2);

                }
          
            /*
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            */




        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

