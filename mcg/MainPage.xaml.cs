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
using System.Windows.Navigation;
using System.Windows.Shapes;
using me.coldandtired.mcg.Models;
using System.Collections.ObjectModel;

namespace me.coldandtired.mcg
{
    public partial class MainPage : UserControl
    {
        public static Mobs mobs = new Mobs();

        public MainPage()
        {
            InitializeComponent();
            ContentFrame.DataContext = mobs;
        }

        // If an error occurs during navigation, show an error window
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ChildWindow errorWin = new ErrorWindow(e.Uri);
            errorWin.Show();
        }

        private void remove(object sender, Microsoft.Windows.DragEventArgs e)
        {
            //remove from all
            e.Handled = true;
        }

        private void show_home_page(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("/Home", UriKind.Relative));
        }

        private void removing(object sender, Microsoft.Windows.DragEventArgs e)
        {//NavigationService.CurrentSource
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (dropped.First().Item is Image || (dropped.First().Item is Base_type && !(dropped.First().Item is Condition))) 
                e.Effects = Microsoft.Windows.DragDropEffects.None;
            
            e.Handled = true;
        }
    }
}