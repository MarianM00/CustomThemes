using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomThemes.Themes.ThemeHelper
{

    /// <summary>
    /// Here add a new theme
    /// </summary>
    public enum ThemeType
    {
        SoftDark,
        LightTheme,
    }

    /// <summary>
    /// Extension method for enum
    /// </summary>
    public static class ThemeTypeExtension
    {
        public static string GetName(this ThemeType type)
        {
            switch (type)
            {
                case ThemeType.SoftDark: return "SoftDark";
                case ThemeType.LightTheme: return "LightTheme";
                default: throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
