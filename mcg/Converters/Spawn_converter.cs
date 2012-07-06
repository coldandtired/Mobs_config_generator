using System;

namespace me.coldandtired.mcg.Converters
{
    public class Spawn_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool b = (bool)value;
            string param = (string)parameter;
            if (param == "tooltip")
            {
                if (b) return "Click to block spawning"; else return "Click to allow spawning";
            }
            else if (param == "opacity")
            {
                if (b) return 0.3; else return 1;
            }
            return null;
        }
    }
}
