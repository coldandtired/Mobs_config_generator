using System;

namespace me.coldandtired.mcg.Converters
{
    public class Toggle_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Yes"; else return "No";
        }
    }
}
