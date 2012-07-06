using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using me.coldandtired.mcg.Models;
namespace me.coldandtired.mcg.Views
{
    public partial class Mob_page : Page
    {
        public Mob_page()
        {
            InitializeComponent();
            all_conditions_box.DataContext = MainPage.mobs.condition_group_pool;        
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.mobs.condition_group_pool = new ObservableCollection<Condition_group>();
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "2" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "1" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "3" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "4" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "5" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "6" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "7" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "8" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "9" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "10" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "11" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "12" });
            MainPage.mobs.condition_group_pool.Add(new Condition_group { id = "13" });
           // MainPage.mobs.creatures = new ObservableCollection<Mob>();
            all_conditions_box.DataContext = MainPage.mobs.condition_group_pool;   
           // Mob m = new Mob();
            //MainPage.mobs.creatures.Add(m);
           // App.selected_mob = m;
            DataContext = App.selected_mob;
        }

        private void block_bin(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);
            e.Effects = Utils.block_bin_moving(e);
            e.Handled = true;
        }

        private void add_outcome(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            Condition_group cg = (Condition_group)dropped.First().Item;

            Mob m = (Mob)DataContext;
            if (m.outcomes == null) m.outcomes = new ObservableCollection<Outcome>();
            Outcome o = new Outcome();
            o.condition_groups = new ObservableCollection<string>();
            o.condition_groups.Add(cg.id);
            m.outcomes.Add(o);
        }

        private void add_condition_group(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (!(dropped.First().Item is Condition_group)) return;

            Condition_group cg = (Condition_group)dropped.First().Item;

            Outcome o = (Outcome)(sender as ListBoxDragDropTarget).DataContext;
            bool b = false;
            if (o.condition_groups != null)
            {
                foreach (string s in o.condition_groups) if (s == cg.id) b = true;
            }
            if (!b)
            {
                if (o.condition_groups == null) o.condition_groups = new ObservableCollection<string>();
                o.condition_groups.Add(cg.id);
            }            
            e.Handled = true;
        }

        private void adding_condition_group(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (!(dropped.First().Item is Condition_group))
            {
                e.Effects = Microsoft.Windows.DragDropEffects.None;
                e.Handled = true;
                return;
            }

            Condition_group cg = (Condition_group)dropped.First().Item;

            Outcome o = (Outcome)(sender as ListBoxDragDropTarget).DataContext;
            bool b = false;
            if (o.condition_groups != null)
            {
                foreach (string s in o.condition_groups) if (s == cg.id) b = true;
            }
            if (b) e.Effects = Microsoft.Windows.DragDropEffects.None; else e.Effects = Microsoft.Windows.DragDropEffects.Copy;
            e.Handled = true;
        }

        private void select_outcome(object sender, RoutedEventArgs e)
        {
            App.selected_outcome = (Outcome)(sender as Button).DataContext;
            NavigationService.Navigate(new Uri("/Outcome_page", UriKind.Relative));
        }
    }
}
