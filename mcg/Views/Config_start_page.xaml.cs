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
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Views
{
    public partial class Config_start_page : Page
    {
        public Config_start_page()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.mobs.mob_pool = new System.Collections.ObjectModel.ObservableCollection<Mob>();
            MainPage.mobs.mob_pool.Add(new Mob { name = "cow" });
            DataContext = MainPage.mobs;
           // all_mobs_list.ItemsSource = new Mob_list();
        }

        private void show_mob_page(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(NavigationService.CurrentSource.ToString());
        }

        private void adding_mob(object sender, Microsoft.Windows.DragEventArgs e)
        {

        }

        private void add_mob(object sender, Microsoft.Windows.DragEventArgs e)
        {

        }

    }
}
