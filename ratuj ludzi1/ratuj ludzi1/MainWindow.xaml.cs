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
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace ratuj_ludzi1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            enemyTimer.Tick += enemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);


           targetTimer.Tick += targetTimer_Tick;
           targetTimer.Interval = TimeSpan.FromSeconds(.1);

        }
        void enemyTimer_Tick(object sender, object e)
        {
            throw new NotImplementedException();
        }
        void enemyTimer(object sender, object e)
        {
            throw new NotImplementedException();
        }
        
        void targetTimer_Tick(object sender, object e)
        {
            ProgressBar.ValueProperty += 1;
            if (ProgressBar.ValueProperty >= ProgressBar.Maximum)
            {
                EndTheGame();
            }
        }
        private void EndTheGmae()
        {
            if (!playArea.Children.Contains(gameOverText))
            {
                enemyTimer.Stop();
                targetTimer_Tick().Stop();
                humanCaptured = false;
                startButton.Visibility = Visibility.Visible;
                playArea.Children.Add(gameOverText);
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void startButton_Click(object sendder, RoutedEventArgs e)
        {
            AddEnemy();

        }
        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight - 100), random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);

        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(
                    random.Next(4, 6)))
            };
            Storyboard.SetTarget(animation, enemy);
         
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public sealed partial class MainPage : ratuj_Ludzi1.Common.LayoutAwarePage
        {
            Random random = new Random();
            DispatcherTimer enemyTimer = new DispatcherTimer();
            DispatcherTimer targetTimer = new DispatcherTimer();
            bool humanCaptured = false;
        }
        private void StartGame()
        {
            human.IsHitTestVisible = true;
            humanCaptured = false;
            ProgressBar.ValueProperty = 0;
            startButton.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(target);
            playArea.Children.Add(human);
            enemyTimer().Start();
            targetTimer.Start();
        }
        void enemyTimer_Tick(object sender, object e)
        {
            AddEnemy();
        }
        private void human_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if(enemyTimer().IsEnabled)
            {
                humanCaptured = true;
                human_IsHitTestVisible = false;
            }
        }
        private void target_PointerEnterd(object sender, PointerRoutedEventArgs e)
        {
            if(targetTimer.IsEnabled && human_PointerPressedCaptured)
            {
                ProgressBar.Value = 0;
                Canvas.SetLeft(target_PointerEnterd, random.Next(100, (int)playArea.ActualWidth - 100));
            }
        }
    }
}
