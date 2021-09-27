using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = UTF8Encoding.UTF8.GetBytes(toEncode);
            string returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;

            /*
             * zakodowanie danych w sekwencje bajtów
             * przekonwertowanie danych na base64
             * zwrócenie zawartości returnValue
             */
        }
        //kompresja
        static string Compress(string uncompressedString)
        {
            byte[] compressedBytes;
            using (var uncompressedStream = new MemoryStream(Encoding.UTF8.GetBytes(uncompressedString)))
            {
                using (var compressedStream = new MemoryStream())
                {
                    using (var compressorStream = new DeflateStream(compressedStream, CompressionLevel.Fastest, true))
                    {
                        uncompressedStream.CopyTo(compressorStream);
                    }
                    compressedBytes = compressedStream.ToArray();
                }
            }
            return Convert.ToBase64String(compressedBytes);
        }
        //kompresja

        //dekompresja
        string Decompress(string compressedString)
        {
            byte[] decompressedBytes;
            var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));
            compressedString = compressedbase64.Text;
            using (var decompressorStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
            {
                using (var decompressedStream = new MemoryStream())
                {
                    decompressorStream.CopyTo(decompressedStream);
                    decompressedBytes = decompressedStream.ToArray();
                }
            }
            return Encoding.UTF8.GetString(decompressedBytes);
        }
        //dekompresja

        //INPUT NA BASE 64-Sprawne
        //
        //
        //
        //
        //
        //
        //
        //konwersja tekstu na base64
            private void button1_Click(object sender, EventArgs e)
            {
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
                /*
                 * podpięcie myData do inputa, aby pobrać z niego tekst
                 * W przecwnym wypadku textBox2 wyświetli zakodowaną wartość
                 */
            }
            //
            //kopiowanie wartości
            private void CopyButton1_Click(object sender, EventArgs e)
            {
                // Jeśli string wynosi null, lub jest pusty wyświetli się komunikat by uzupełnić dane
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Wypełnij pole, aby skopiować");
                }
                // w przeciwnym wypadku skopiowana zostanie zawartość textBox2
                else
                {
                    Clipboard.SetText(textBox2.Text);
                }
            }
            //
            //skompresowanie base64
            //
            //w przypadku kliknięcia wyczyszczone zostaną wartości obydwu inputó
            private void CopyButton2_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            private void button2_Click(object sender, EventArgs e)
            {
                string path = @"C:\Users\xopero\Desktop\test.txt";
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string c = "";
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        c += s + "\n";
                    }
                    MessageBox.Show(c);
                }
            }
            private void button4_Click(object sender, EventArgs e)
            {
                //zmienna, która zawiera ścieżkę, w której zapisze się plik i jaki będzie miał format oraz nazwę
                string path = @"C:\Users\xopero\Desktop\test.txt";
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string info1 = "Wpisana Wartość: ";
                string info2 = "\nZakodowana Wiadomość: ";
                //Tworzy plik i nadaje mu treść
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(info1 + text1 + info2 + text2);
                }
            }

        //
        //
        //
        //
        //
        //
        //KONIEC INPUT NA 64



        //kompresja base 64

            private void CompressedButton_Click(object sender, EventArgs e)
            {
             
                string compressed = textBox1.Text;
                string compress = Compress(compressed);
                compressedbase64.Text = compress;                                            //dekompresja
                string decompressed = Decompress(compressedbase64.Text);
                byte[] toEncodeAsBytes = UTF8Encoding.UTF8.GetBytes(decompressed);
                string returnValue = Convert.ToBase64String(toEncodeAsBytes);               //przekonwertowanie danych na base64
                string myDataEncoded = EncodeTo64(decompressed);
                compressed1.Text = myDataEncoded;
                string path = @"C:\Users\xopero\Desktop\Compression1.txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("skompresowany: " + compressedbase64.Text + "\nzdekompresowany: " + compressed1.Text);
                }
            }
        //Kompresja base64
        //



        //Kompresja stringa, base64-KONIEC
        //


        //Dekompresja base64 
        //
        //



        //Kompresja base 64-KONIEC
        //
        //






        //BASE 64 NA INPUT-sprawne
        //
        //
        //
        //
        //
        //
        private void button3_Click(object sender, EventArgs e)
        {
            string myData = TextBoxToInput.Text;
            string test = UTF8Encoding.UTF8.GetString(Convert.FromBase64String(myData));
            if (String.IsNullOrEmpty(myData))
            {
                MessageBox.Show("Wypełnij Pole!");
            }
            else
            {
                TextBoxToInput2.Text = test;
            }
            /*
             * zmienna pobiera dane z inputa, następnie za pomocą zmiennej test konwertuje je z base64 na zwykły teksty zwarty w stringu
             * jeśli pole jest puste, zadanie nie wykona się i wyświetli komunikat
             * w przeciwnym wypadku input2 otrzyma zawartość zmiennej tekst
             */
        }
        //kopiuje wartość z inputa zawierającego tekst przeniesiony z base64
        private void button5_Click(object sender, EventArgs e)
        {
            //Jeśli Input jest pusty, lub wartość wyniesie Null funkcja nie wykona się i poda informację, aby wprowadzić dane
            if (String.IsNullOrEmpty(TextBoxToInput2.Text))
            {
                MessageBox.Show("Wypełnij pole, aby skopiować");
            }
            //W przeciwnym wypadku skopiuje wartość inputa z wynikiem
            else
            {
                Clipboard.SetText(TextBoxToInput2.Text);
            }
        }
        //
        //Czyści wartości inputów
        private void ClearButton2_Click_1(object sender, EventArgs e)
        {
            TextBoxToInput.Clear();
            TextBoxToInput2.Clear();
        }
        //
        private void button6_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Users\xopero\Desktop\test2.txt";
            string text1 = TextBoxToInput.Text;
            string text2 = TextBoxToInput2.Text;
            string info1 = "Wpisana Wartość: ";
            string info2 = "\nZakodowana Wiadomość: ";
            //Tworzy plik i nadaje mu treść
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(info1 + text1 + info2 + text2);
            }
        }
        private void OpenFile2_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\Users\xopero\Desktop\test2.txt";
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path2))
            {
                string c = "";
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    c += s + "\n";
                }
                MessageBox.Show(c);
            }
        }
        //
        //
        //
        //
        //
        //
        //BASE 64 NA INPUT

    }
}