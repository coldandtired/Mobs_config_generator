using System;
using System.Windows;
using System.Windows.Media;

namespace me.coldandtired.mcg.Converters
{
    public class Background_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((Boolean)value == true) return (SolidColorBrush)Application.Current.Resources["error_colour"]; else return "white";
        }
    }
}
