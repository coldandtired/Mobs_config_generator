using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Converters
{
    public class Condition_summary_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Condition_group cg = null;
            if (value is Condition_group) cg = (Condition_group)value;
            else
            {
                foreach (Condition_group c in MainPage.mobs.condition_group_pool) if (c.id == (string)value) cg = c;
            }
            return cg.id;
            /* string s = m.display_name;
             if (m.outcomes == null || m.outcomes.Count == 0) return string.Format("{0}{1}No outcomes set yet", s, Environment.NewLine);
             else
             {
                 int i = m.outcomes.Count;
                 if (i == 1) return string.Format("{0}{1}1 outcome set", s, Environment.NewLine);
                 else return string.Format("{0}{1}{2} outcomes set", s, Environment.NewLine, i.ToString());
             }*/
        }
    }
}
