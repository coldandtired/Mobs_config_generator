using System;

namespace me.coldandtired.mcg.Converters
{
    public class Log_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Log messages"; else return "Don't log messages";
        }
    }
}
