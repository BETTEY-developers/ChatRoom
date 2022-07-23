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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Consultation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard _storyboard;
        DoubleAnimation DoubleAnimation;

        public MainWindow()
        {
            InitializeComponent();
            WidTile.Content = "MS Marika 资讯广场";
            _storyboard = new Storyboard();
            DoubleAnimation = new DoubleAnimation();
            DoubleAnimation.Duration = new Duration(TimeSpan.FromTicks(1000));
            DoubleAnimation.From = 0.0;
            DoubleAnimation.To = 1.0;
            DoubleAnimation.AutoReverse = true;
            DoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            _storyboard.Children.Add(DoubleAnimation);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
