using System;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_combobox_colour_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is Condition)) return "Black";

            Condition c = (Condition)value;
            if (c.reversed) return "Red"; else return "Black";
        }
    }
}
