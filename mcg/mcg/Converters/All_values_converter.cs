using System;

namespace me.coldandtired.mcg.Converters
{
    public class All_values_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "And"; else return "Or";
        }
    }
}
