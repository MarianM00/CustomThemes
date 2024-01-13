using CustomThemes.Commands;
using CustomThemes.Themes.ThemeEnum;
using CustomThemes.Themes.ThemesController;
using System.Windows.Input;

namespace CustomThemes.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand ChangeThemeCommand { get; set; }

        public MainViewModel()
        {
            ChangeThemeCommand = new RelayCommand(ChangeTheme, _ => true);
        }

        private void ChangeTheme(object parameter)
        {
            if (parameter is not string themeId) return;
            switch (themeId)
            {
                case "SoftDark": ThemesController.SetTheme(ThemeType.SoftDark); break;
                case "Light": ThemesController.SetTheme(ThemeType.LightTheme); break;
            }
        }
    }
}
