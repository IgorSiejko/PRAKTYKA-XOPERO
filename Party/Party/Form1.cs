using System;
using System.Windows.Forms;
namespace Party
{
    public partial class Form1 : Form
    {
        // DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void result_TextChanged(object sender, EventArgs e)
        {
        }
        void button1_Click(object sender, EventArgs e)
        {
            int guestsnmb = Int16.Parse(Guests1.Text);
            int healthyopt = 5 * guestsnmb;
           
            double unhealthyopt = 20 * guestsnmb;
            double decoration = ((15 * guestsnmb) + 50);
            double nodecoration = 7.5 * guestsnmb + 30;
            //zadeklarowanie zmiennych odpowiedzialnych z stałe dane
            if (decorationFantasy.Checked && healthyOption.Checked)
            {
                double price = (decoration + healthyopt)-(decoration + healthyopt)/20;
                Console.WriteLine(price);
                string convert = price.ToString();
                result.Text = convert;
            }
            else if (!decorationFantasy.Checked && !healthyOption.Checked)
            {
                double price = (nodecoration + unhealthyopt);
                string convert = price.ToString();
                result.Text = convert;
            }
            else if (decorationFantasy.Checked && !healthyOption.Checked)
            {
                double price = (decoration + unhealthyopt);
                string convert = price.ToString();
                result.Text = convert;
            }
            else if (!decorationFantasy.Checked && healthyOption.Checked)
            {
                double price = (nodecoration + healthyopt) -(nodecoration + healthyopt) / 20;
                string convert = price.ToString();
                result.Text = convert;
            }
            //Warunki sprawdzające, które kontrolki zostały wybrane
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Guests1.Clear();
            result.Clear();
            //czyści wartośći w inputach
        }
    }
}
