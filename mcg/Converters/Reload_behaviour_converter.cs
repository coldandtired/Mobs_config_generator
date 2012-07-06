using System;

namespace me.coldandtired.mcg.Converters
{
    public class Reload_behaviour_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                int i = (int)value;
                switch (i)
                {
                    case 0: return "Remove";
                    case 1: return "Kill";
                    case 2: return "Vanilla";
                    case 3: return "Outcome";
                    case 4: return "Recalc.";
                }
            }
            return "Kill";
        }
    }
}
