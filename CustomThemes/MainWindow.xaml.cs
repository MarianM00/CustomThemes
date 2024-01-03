using CustomThemes.Themes.ThemeHelper;
using CustomThemes.Themes.ThemesController;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomThemes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            switch (((MenuItem)sender).Uid)
            {
                case "0": ThemesController.SetTheme(ThemeType.SoftDark); break;
                case "1": ThemesController.SetTheme(ThemeType.LightTheme); break;
            }

            e.Handled = true;
        }
    }
}