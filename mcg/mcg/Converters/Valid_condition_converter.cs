using System;
using me.coldandtired.mcg.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace me.coldandtired.mcg.Converters
{
    public class Valid_condition_converter : Base_converter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (((int)value) == 0) return "Red"; else return "Blue";
        }
    }
}
