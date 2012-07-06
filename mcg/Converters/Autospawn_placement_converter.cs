using System;

namespace me.coldandtired.mcg.Converters
{
    public class Autospawn_placement_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                int i = (int)value;
                switch (i)
                {
                    case 0: return "Above ground";
                    case 1: return "Below ground";
                    case 2: return "Either";
                }
            }
            return "Above ground";
        }
    }
}
