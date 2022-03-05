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
        Storyboard broad = new Storyboard();
        DoubleAnimation da = new DoubleAnimation();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)e.Source;
            
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }
    }
}
