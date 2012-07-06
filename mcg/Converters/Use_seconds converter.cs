using System;

namespace me.coldandtired.mcg.Converters
{
    public class Use_seconds_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "seconds"; else return "minutes";
        }
    }
}
