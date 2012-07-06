using System;

namespace me.coldandtired.mcg.Converters
{
    public class Base_enabled_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return false; else return true;
        }
    }
}
