using System;

namespace me.coldandtired.mcg.Converters
{
    public class Damage_check_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                int i = (int)value;
                switch (i)
                {
                    case 0: return "Spawn";
                    case 1: return "Damage";
                    case 2: return "Both";
                }
            }
            return "Spawn";
        }
    }
}
