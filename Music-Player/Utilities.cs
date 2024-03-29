using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Music_Player
{
    public static class ColorPainter
    {
        public static SolidColorBrush SetColorBrush(string colorHexCode)
        {
            SolidColorBrush newColor = new SolidColorBrush();
            newColor.Color = (Color)ColorConverter.ConvertFromString(colorHexCode);
            return newColor;
        }
    } 

    public struct ColorPalette
    {
        public string mainBackground;
        public string secondaryBackground;
        public string titleText;
        public string mainText;
        public string buttons;

        public ColorPalette(string mainBackground, string leftMenuBackground, string titleText, string mainText, string buttons)
        {
            this.mainBackground = mainBackground;
            this.secondaryBackground = leftMenuBackground;
            this.titleText = titleText;
            this.mainText = mainText;
            this.buttons = buttons;
        }
    }
}
