using System;
using System.Windows;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_value_textbox_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((string)parameter == (string)value) return Visibility.Collapsed; else return Visibility.Visible;
        }
    }
}
