using System;

namespace me.coldandtired.mcg.Converters
{
    public class Affected_mobs_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string param = (string)parameter;
            if (param == "tooltip")
            {
                if (value != null)
                {
                    int i = (int)value;
                    switch (i)
                    {
                        case 0: return "All mobs affected";
                        case 1: return "Naturally spawned mobs only";
                        case 2: return "Autospawned mobs only";
                    }
                }
                return "All mobs affected";
            }
            else if (param == "opacity")
            {
                if (value != null)
                {
                    int i = (int)value;
                    switch (i)
                    {
                        case 0: return 0.3;
                        case 1: return 1;
                        case 2: return 1;
                    }
                }
                return 0.3;
            }
            return null;
        }
    }
}
