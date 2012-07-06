using System;

namespace me.coldandtired.mcg.Converters
{
    public class Can_save_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((Boolean)value == true) return 1; else return 0.25;
        }
    }
}
