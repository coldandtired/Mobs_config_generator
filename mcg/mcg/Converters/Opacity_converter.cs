using System;

namespace me.coldandtired.mcg.Converters
{
    public class Opacity_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null) return 1; else return 0.3;
        }
    }
}
