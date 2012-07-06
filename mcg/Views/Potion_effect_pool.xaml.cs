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
using System.Windows.Navigation;
using me.coldandtired.mcg.Popups;
using System.Collections.ObjectModel;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Views
{
    public partial class Potion_effect_pool : Page
    {
        public Potion_effect_pool()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LayoutRoot.DataContext = MainPage.mobs;
        }        

        private void test(object sender, RoutedEventArgs e)
        {
            
        }

        private void adding_potion_effect(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (!(dropped.First().Item is Condition_group))
            {
                e.Effects = Microsoft.Windows.DragDropEffects.None;
                e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void add_potion_effect(object sender, Microsoft.Windows.DragEventArgs e)
        {
            Potion_effect_popup window = new Potion_effect_popup();
            window.Closed +=new EventHandler(popup_closed);
            window.Show();
        }


        public void popup_closed(object sender, EventArgs e)
        {
            Potion_effect_popup window = (Potion_effect_popup)sender;
            if (window.DialogResult == true)
            {
               if (MainPage.mobs.potion_effect_pool == null) MainPage.mobs.potion_effect_pool = new ObservableCollection<Potion_effect_group>();
                MainPage.mobs.potion_effect_pool.Add(new Potion_effect_group());
            }
          //  MessageBox.Show(window.DialogResult.ToString());
        }

        private void add_potion_effect_group(object sender, Microsoft.Windows.DragEventArgs e)
        {
            if (MainPage.mobs.potion_effect_pool == null) MainPage.mobs.potion_effect_pool = new ObservableCollection<Potion_effect_group>();
            MainPage.mobs.potion_effect_pool.Add(new Potion_effect_group());
            e.Handled = true;
        }
    }
}
