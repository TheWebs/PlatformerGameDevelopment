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

namespace PlatformerGameDevelopment
{
    /// <summary>
    /// Interaction logic for Credits.xaml
    /// </summary>
    public partial class Credits : UserControl
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Back_MouseEnter(object sender, MouseEventArgs e)
        {
            Back.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF30648F"));
            Back.Margin = new Thickness(Back.Margin.Left - 2, Back.Margin.Top - 2, 0, 0);
        }

        private void Back_MouseLeave(object sender, MouseEventArgs e)
        {
            Back.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF464646"));
            Back.Margin = new Thickness(Back.Margin.Left + 2, Back.Margin.Top + 2, 0, 0);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
