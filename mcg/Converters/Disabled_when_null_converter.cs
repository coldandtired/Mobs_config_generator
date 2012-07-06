using System;

namespace me.coldandtired.mcg.Converters
{
    public class Disabled_when_null_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return false; else return true;
        }
    }
}
