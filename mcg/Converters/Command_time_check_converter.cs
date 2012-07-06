using System;

namespace me.coldandtired.mcg.Converters
{
    public class Command_time_check_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Checks"; else return "Ignores";
        }
    }
}
