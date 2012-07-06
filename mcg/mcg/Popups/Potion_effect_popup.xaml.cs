using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Popups
{
    public partial class Potion_effect_popup : ChildWindow
    {
        public Potion_effect potion_effect { get; set; }

        public Potion_effect_popup(Potion_effect pe = null)
        {
            InitializeComponent();
            if (pe == null) potion_effect = new Potion_effect(); else potion_effect = pe;
            LayoutRoot.DataContext = potion_effect;
        }

        private void add(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void toggle_seconds(object sender, RoutedEventArgs e)
        {

        }

        private void check_level(object sender, TextChangedEventArgs e)
        {

        }

        private void clear_box(object sender, RoutedEventArgs e)
        {

        }

        private void show_help(object sender, RoutedEventArgs e)
        {

        }
    }
}

