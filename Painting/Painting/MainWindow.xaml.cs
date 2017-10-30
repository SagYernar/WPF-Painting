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

namespace Painting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Yellow;
            colorAnimation.Duration = TimeSpan.FromSeconds(3);
            colorAnimation.AutoReverse = true;
            colorAnimation.RepeatBehavior = new RepeatBehavior(15);
            button.Background = new SolidColorBrush(Colors.Green);

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = button.Width;
            widthAnimation.To = 150;
            widthAnimation.Duration = TimeSpan.FromSeconds(3);
            widthAnimation.AutoReverse = true;
            widthAnimation.RepeatBehavior = new RepeatBehavior(15);

            button.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
            button.BeginAnimation(WidthProperty, widthAnimation);
        }
    }
}
