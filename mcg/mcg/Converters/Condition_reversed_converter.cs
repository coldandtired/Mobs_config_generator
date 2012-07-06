using System;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_reversed_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value) return "Reversed"; else return "Normal";
        }
    }
}
