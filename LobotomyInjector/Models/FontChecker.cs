using System;
using System.Drawing;

namespace LobotomyInjector.Models
{
    internal class FontChecker
    {
        public static bool IsFontInstalled(string fontName)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                if (fontFamily.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
