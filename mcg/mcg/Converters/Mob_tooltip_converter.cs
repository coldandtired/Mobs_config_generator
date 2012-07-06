using System;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Converters
{
    public class Mob_tooltip_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Mob m = (Mob)value;
            string s = m.display_name;
            if (m.outcomes == null || m.outcomes.Count == 0) return string.Format("{0}{1}No outcomes set yet", s, Environment.NewLine);
            else
            {
                int i = m.outcomes.Count;
                if (i == 1) return string.Format("{0}{1}1 outcome set", s, Environment.NewLine);
                else return string.Format("{0}{1}{2} outcomes set", s, Environment.NewLine, i.ToString());
            }
        }
    }
}
