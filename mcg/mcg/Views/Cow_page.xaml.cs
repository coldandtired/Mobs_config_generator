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
using System.Collections.ObjectModel;

namespace me.coldandtired.mcg.Views
{
    public partial class Cow_page : Page
    {
        public Cow_page()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Cow cow = null;
            if (MainPage.mobs != null && MainPage.mobs.mob_pool != null)
            {
                foreach (Mob m in MainPage.mobs.mob_pool) if (m is Cow) cow = (Cow)m;
            }
            if (cow == null) cow = new Cow();
            LayoutRoot.DataContext = cow;
           // Cow cow2 = new Cow();
           // cow2.condition_groups = new ObservableCollection<Condition_group>();
          //  test.ItemsSource = cow2.condition_groups;
            //if (MainPage.mobs == null) MainPage.mobs = new Models.Mobs();
           // if (MainPage.mobs.creatures == null) MainPage.mobs.creatures = new List<Mob>();
        }

        private void add_base_outcome(object sender, Microsoft.Windows.DragEventArgs e)
        {

        }

        private void ListBoxDragDropTarget_DragOver(object sender, Microsoft.Windows.DragEventArgs e)
        {
           // e.Effects = Microsoft.Windows.DragDropEffects.Copy;
            e.Handled = true;

        }

        private void PanelDragDropTarget_DragOver(object sender, Microsoft.Windows.DragEventArgs e)
        {
           /* var format = e.Data.GetFormats()[0];
            ItemDragEventArgs dragItem = e.Data.GetData(format) as ItemDragEventArgs;
            SelectionCollection selectedItems = dragItem.Data as SelectionCollection;

            Condition_group cg = (Condition_group)selectedItems.First().Item;
            MessageBox.Show(cg.test);
           // e.Effects = Microsoft.Windows.DragDropEffects.Move;*/
            e.Handled = true;
        }

        private void PanelDragDropTarget_DragOver_1(object sender, Microsoft.Windows.DragEventArgs e)
        {
            e.Handled = true;
        }
    }
}
