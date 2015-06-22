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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Start_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Start_Button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF30648F"));
            Start_Button.Margin = new Thickness(Start_Button.Margin.Left - 2, Start_Button.Margin.Top -2, 0, 0);
        }

        private void Start_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Start_Button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF464646"));
            Start_Button.Margin = new Thickness(Start_Button.Margin.Left + 2, Start_Button.Margin.Top + 2, 0, 0);
        }

        private void Credits_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Credits_Button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF30648F"));
            Credits_Button.Margin = new Thickness(Credits_Button.Margin.Left - 2, Credits_Button.Margin.Top - 2, 0, 0);
        }

        private void Credits_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Credits_Button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF464646"));
            Credits_Button.Margin = new Thickness(Credits_Button.Margin.Left + 2, Credits_Button.Margin.Top + 2, 0, 0);
        }

        private void Exit_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Exit_button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF30648F"));
            Exit_button.Margin = new Thickness(Exit_button.Margin.Left - 2, Exit_button.Margin.Top - 2, 0, 0);
        }

        private void Exit_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Exit_button.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF464646"));
            Exit_button.Margin = new Thickness(Exit_button.Margin.Left + 2, Exit_button.Margin.Top + 2, 0, 0);
        }

        private void Credits_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Credits());
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LevelSelectPage());
        }
    }
}
