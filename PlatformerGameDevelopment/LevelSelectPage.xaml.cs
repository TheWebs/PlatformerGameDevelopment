using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Interaction logic for LevelSelectPage.xaml
    /// </summary>
    public partial class LevelSelectPage : UserControl
    {
        public LevelSelectPage()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Nivel1 == false)
            {
                BitmapImage image = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/UnlockedLevel.png"));
                Level1.Source = image;
                Level1.Cursor = Cursors.Hand;
                image = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/LockedLevel.png"));
                Level2.Source = image;
                Level2.ToolTip = "Level 2 is locked!";
                Level3.Source = image;
                Level3.ToolTip = "Level 3 is locked!";
                Level4.Source = image;
                Level4.ToolTip = "Level 4 is locked!";
                Level5.Source = image;
                Level5.ToolTip = "Level 5 is locked!";



            }

            if (Properties.Settings.Default.Nivel2 == false)
            {
                BitmapImage image = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/UnlockedLevel.png"));
                Level1.Source = image;
                Level1.Cursor = Cursors.Hand;
                Level2.Source = image;
                Level2.Cursor = Cursors.Hand;
                image = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/LockedLevel.png"));
                Level3.Source = image;
                Level3.ToolTip = "Level 3 is locked!";
                Level4.Source = image;
                Level4.ToolTip = "Level 4 is locked!";
                Level5.Source = image;
                Level5.ToolTip = "Level 5 is locked!";
            }
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


        private void Level1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new Level1());
        }
    }
}
