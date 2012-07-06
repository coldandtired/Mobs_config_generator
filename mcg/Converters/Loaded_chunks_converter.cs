using System;

namespace me.coldandtired.mcg.Converters
{
    public class Loaded_chunks_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value == true) return "Loaded chunks only"; else return "All chunks";
        }
    }
}
