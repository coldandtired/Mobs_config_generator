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
using System.Collections.ObjectModel;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Views
{
    public partial class Mob_pool : Page
    {
        public Mob_pool()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = MainPage.mobs;
            all_mobs_list.ItemsSource = new Mob_list();
        }

        private void show_mob_page(object sender, RoutedEventArgs e)
        {
            App.selected_mob = (Mob)(sender as Button).DataContext;
            NavigationService.Navigate(new Uri("/Mob_page", UriKind.Relative));
        }

        private void adding_mob(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (!(dropped.First().Item is Base_type))
            {
                e.Effects = Microsoft.Windows.DragDropEffects.None;
                e.Handled = true;
                return;
            }

            e.Effects = Microsoft.Windows.DragDropEffects.Copy;
            e.Handled = true;
        }

        private void add_mob(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (!(dropped.First().Item is Base_type)) return;

            Base_type bt = (Base_type)dropped.First().Item;
            if (MainPage.mobs.mob_pool == null) MainPage.mobs.mob_pool = new ObservableCollection<Mob>();

            if (bt.name != "CUSTOM") add_mob_details(bt.name, bt.display_name);
            else
            {
                InputTextBox.Text = "";
                InputBox.Visibility = Visibility.Visible;
                InputTextBox.Focus();
            }
        }

        private void add_mob_details(string name, string display_name)
        {
            Mob m = new Mob();
            m.name = name;
            m.display_name = display_name;
            MainPage.mobs.mob_pool.Add(m);
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            string s = InputTextBox.Text;
            bool b = false;
            if (MainPage.mobs.mob_pool != null)
            {
                foreach (Mob m in MainPage.mobs.mob_pool) if (s.ToLower() == m.name.ToLower()) b = true;
            }
            if (!b)
            {
                InputBox.Visibility = Visibility.Collapsed;
                add_mob_details(s, s);
            }
            else MessageBox.Show("There's already a mob with that name!");
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Collapsed;
        }
    }
}
