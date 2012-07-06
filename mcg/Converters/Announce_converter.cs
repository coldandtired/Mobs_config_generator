using System;

namespace me.coldandtired.mcg.Converters
{
    public class Announce_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Announce messages"; else return "Don't announce messages";
        }
    }
}
