using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CustomThemes.Themes.ThemeHelper;

namespace CustomThemes.Themes.ThemesController
{
    public class ThemesController
    {
        public static ThemeType CurrentTheme { get; set; }

        private static ResourceDictionary ThemeDictionary
        {
            get => Application.Current.Resources.MergedDictionaries[0];
            set => Application.Current.Resources.MergedDictionaries[0] = value;
        }

        private static ResourceDictionary ControlColours
        {
            get => Application.Current.Resources.MergedDictionaries[1];
            set => Application.Current.Resources.MergedDictionaries[1] = value;
        }


        public static void SetTheme(ThemeType theme)
        {
            string themeName = theme.GetName();
            if (string.IsNullOrEmpty(themeName))
            {
                return;
            }

            CurrentTheme = theme;
            ThemeDictionary = new ResourceDictionary()
            {
                Source = new Uri($"Themes/ThemeStyle/{themeName}.xaml", UriKind.Relative)
            };
            ControlColours = new ResourceDictionary()
            {
                Source = new Uri("/CustomThemes;component/Themes/DinamycControls/ControlColours.xaml", UriKind.Relative)
            };

        }
    }
}
