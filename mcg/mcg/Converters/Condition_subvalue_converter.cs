using System;
using System.Windows;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_subvalue_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return Visibility.Collapsed;
            if (((string)value).Contains((string)parameter)) return Visibility.Visible; else return Visibility.Collapsed;
        }
    }
}
