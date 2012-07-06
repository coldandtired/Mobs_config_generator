using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Views
{
    public partial class Drops_pool : Page
    {
        public Drops_pool()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void edit_enchantments(object sender, RoutedEventArgs e)
        {

        }

        private void check_chance(object sender, TextChangedEventArgs e)
        {

        }

        private void check_quantity(object sender, TextChangedEventArgs e)
        {

        }

        private void check_data(object sender, TextChangedEventArgs e)
        {

        }

        private void choose_item_name(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_drop(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (dropped.First().Item is Drop) return;

            Mobs mobs = (Mobs)DataContext;
            if (mobs.drops_pool == null) mobs.drops_pool = new ObservableCollection<Drop>();
            mobs.drops_pool.Add(new Drop { id = Guid.NewGuid().ToString() });
        }

        private void adding_drop(object sender, Microsoft.Windows.DragEventArgs e)
        {
            e.Effects = Utils.block_bin_moving(e);
            e.Handled = true;
        }
    }
}
