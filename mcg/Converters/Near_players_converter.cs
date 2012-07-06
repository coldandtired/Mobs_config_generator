using System;

namespace me.coldandtired.mcg.Converters
{
    public class Near_players_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Near players"; else return "All over";
        }
    }
}
