using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            //deklaracja zmienny odpowiedzialnych za: przebytą trasę, początkową trasę, końcową trasę, kwotę zwrotu
            int startingMileage;
            int endingMileage;
            double milesTraveled;
            double reimburseRate = .39;
            double amountOwed;
            public MainWindow()
            {
                InitializeComponent();
            }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            startingMileage = Convert.ToInt32(Button1.Text); 
            endingMileage = Convert.ToInt32(Button2.Text);
            //pobranie danych z pierwszej i drugiej kontrolki i przekonwertowanie ich na inta w celu dalszego przetworzenia


            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                //przebyty dystans to końcowy dystans, od którego odjęto trasę początkową
                
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = amountOwed.ToString() + " zł";
            }
            else // jeśli argument podany wyżej nie będzie się zgadzać zostanie wyświetlona wiadomość umieszczona poniżej
            {
                MessageBox.Show
                    (
                        "Początkowy stan licznika musi być mniejszy niż końcowy", "Nie mogę obliczyć odległości"
                    );
            }

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            startingMileage = Convert.ToInt32(Button1.Text);
            endingMileage = Convert.ToInt32(Button2.Text);
            int milesTraveled2 = endingMileage -= startingMileage;
            MessageBox.Show(milesTraveled2 + " kilometrów", "Przebyta odległość");
        }

        private void Button1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
