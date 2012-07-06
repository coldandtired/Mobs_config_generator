using System;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Converters
{
    public class Mob_opacity : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return 0.3;
            Mobs mobs = (Mobs)value;
            if (mobs.mob_pool == null) return 0.3;
            foreach (Mob m in mobs.mob_pool) if (m.GetType().Name == (string)parameter) return 1;
            return 0.3;
        }
    }
}
