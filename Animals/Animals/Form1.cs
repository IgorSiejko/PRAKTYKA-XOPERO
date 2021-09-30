using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class animal
        {
            public void  Picture(string path)
               {
                //string path= @"E:\epsonScanner.png";
               // Add(Image.FromFile(path));
            }
            /*
            public void Food()
            {
                string plants = "trawa";
                string meat = "mieso";
            }
            */
            public int hunger=100;
            public void Hunger() {
                //int getHungry;
                /*
                for(int i = 0;i<=100;i--)
                {
                    getHungry = hunger - 1;
                    MessageBox.Show(getHungry.ToString());
                }
                */
            }
            //
            public int x;
            public int y;
            public void Boundaries()
            {
                int maxHeight = 100;
                int maxWidth = 100;
                Console.WriteLine(maxHeight+"na"+maxWidth);
                if(x>maxWidth && y>maxHeight)
                {
                    
                    MessageBox.Show("Położenie zwierzaka jest nieprawidłowe, spróbuj ponownie");
                }
                else if(x < maxWidth && y > maxHeight) { MessageBox.Show("Położenie zwierzaka jest nieprawidłowe, spróbuj ponownie");}
                else if (x > maxWidth && y < maxHeight) { MessageBox.Show("Położenie zwierzaka jest nieprawidłowe, spróbuj ponownie"); }
                else
                {
                    MessageBox.Show("Dane są poprawne");
                }

                // rozmiar wybiegu
            }
            public void Locations(){
            }
            //
            public int chooseSound;
            public void MakeNoise()
            {
                string[] sounds = {"","Hau Hau","Miau Miau","Roar Roar","Hip Hip"};
                /*
                string[] sounds;
                sounds[0] = "Hau Hau";
                sounds[1] = "Miau Miau";
                sounds[2] = "Roar Roar";
                sounds[3] = "Hip Hip";
                */
                MessageBox.Show(sounds[chooseSound]);
            }

            //
            public bool food;
            public void Eat()
            {
                //true = trawa
                //false = mieso
                if (food == true)
                {
                    MessageBox.Show("Je trawke");
                }
                else
                {
                    MessageBox.Show("Je miesko");
                }
            }
            //

            //
            public bool isSleeping;
            public int sleepTime;
            public void Sleep()
            {
                if (isSleeping==true) 
                {
                    MessageBox.Show("Śpi");
                }
                else
                {
                    MessageBox.Show("Nie Śpi");
                }
            }
            //
            public void Roam(){}
        }
        public class Hippo : animal {}
        private void Hippo1_Click(object sender, EventArgs e)
        {
            Hippo spot = new Hippo();
            spot.food = false;
            spot.isSleeping = false;
            spot.sleepTime=10;
            spot.x=160;
            spot.y=100;
            spot.chooseSound = 1;
            spot.Eat();
            spot.Hunger();
            spot.Roam();
            spot.Sleep();
            spot.Roam();
            spot.Locations();
            spot.Boundaries();
            spot.MakeNoise();
           // MessageBox.Show();
        }
    }
            /*

            public class Dog { }
            public class Wolf { }
            public class Lion { }
            public class Cat { }
            public class Tiger { }
            */
        }
