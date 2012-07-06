using System;

namespace me.coldandtired.mcg.Converters
{
    public class Potions_type_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "All effects"; else return "One effect";
        }
    }
}
