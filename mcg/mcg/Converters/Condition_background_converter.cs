using System;
using System.Windows;
using System.Windows.Media;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_background_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string s = (string)value;
            switch (s)
            {
                case "range": return (SolidColorBrush)Application.Current.Resources["condition_colour"];
                default: return (SolidColorBrush)Application.Current.Resources["string_colour"];
            }
        }
    }
}
