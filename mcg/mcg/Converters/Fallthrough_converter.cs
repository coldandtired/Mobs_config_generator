using System;

namespace me.coldandtired.mcg.Converters
{
    public class Fallthrough_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                int i = (int)value;
                switch (i)
                {
                    case 0: return "None";
                    case 1: return "Section";
                    case 2: return "Full";
                }
            }
            return "None";
        }
    }
}
