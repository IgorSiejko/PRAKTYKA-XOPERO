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
            public void  Picture()
                {
                }
            public void Food()
            {
                string plants = "trawa";
                string meat = "mieso";
            }
            public void Hunger(int hunger = 100) {
              
                int getHungry;
                for(int i = 0;i<=100;i++)
                {
                    getHungry = hunger - 1;
                    MessageBox.Show(getHungry.ToString());
                }
            }
            public void Boundaries()
            {
                int maxHeihgt = 100;
                int maxWidth = 100;
                // rozmiar wybiegu
            }
            public void Locations(){
                int x;
                int y;
            }
            public void MakeNoise(string noise)
            {
                string[] sounds = { "Hau Hau","Miau Miau","Roar Roar", "Hip Hip"};
            }
            public void Eat()
            {
                //true = trawa
                //false = mieso
                bool food=true;
                if(food == true)
                {
                    MessageBox.Show("Je trawke");
                }
                else
                {
                    MessageBox.Show("Je miesko");
                }
            }
            public void Sleep(){}
            public void Roam(){}
            public class Canine 
            {
                public class Hippo {}
                public class Dog { }
                public class Wolf { }
                public class Lion { }
                public class Cat { }
                public class Tiger { }


            }
          
        }
    }



        
}
