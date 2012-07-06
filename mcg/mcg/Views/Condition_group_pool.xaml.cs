using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg.Views
{
    public partial class Condition_group_pool : Page
    {
        public Condition_group_pool()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = MainPage.mobs;

            #region general conditions

            List<Condition> general_conditions = new List<Condition>();
            general_conditions.Add(new Condition { display_name = "General" });
            general_conditions.Add(new Condition { name = "autospawn_id", display_name = "Autospawn ID", value_type = "string" });
            general_conditions.Add(new Condition { name = "percent", display_name = "Chance", value_type = "range" });
            general_conditions.Add(new Condition
            {
                name = "time",
                display_name = "Real time",
                value_type = "range",
                subvalue_type = "time_type"
            });
            general_conditions.Add(new Condition { name = "autospawn_id", display_name = "Not autospawn ID", value_type = "string", reversed = true });
            general_conditions.Add(new Condition
            {
                name = "time",
                display_name = "Not real time",
                value_type = "range",
                subvalue_type = "time_type",
                reversed = true
            });
            general_conditions_list.ItemsSource = general_conditions;

            #endregion

            #region world conditions

            List<Condition> world_conditions = new List<Condition>();
            world_conditions.Add(new Condition { display_name = "World" });
            world_conditions.Add(new Condition { name = "world_players", display_name = "The names of players in the world", value_type = "string" });
            world_conditions.Add(new Condition { name = "world_names", display_name = "The names of the world", value_type = "string" });
            world_conditions.Add(new Condition { name = "world_type", display_name = "The type of the world", value_type = "string", subvalue_type = "world_type" });
            world_conditions.Add(new Condition { name = "biome_type", display_name = "The types of biome", value_type = "string", subvalue_type = "biome_type" });
            world_conditions.Add(new Condition { name = "regions", display_name = "The names of regions", value_type = "string" });
            world_conditions.Add(new Condition { name = "game_times", display_name = "The Minecraft game time (0 to 24000)", value_type = "range" });
            world_conditions.Add(new Condition
            {
                name = "coordinate",
                display_name = "The world co-ordinate value",
                value_type = "string",
                subvalue_type = "coordinate_type"
            });
            world_conditions.Add(new Condition { name = "light_levels", display_name = "The light level of the block under the mob", value_type = "range" });
            world_conditions.Add(new Condition { name = "raining", display_name = "Raining", value_type = "bool" });
            world_conditions.Add(new Condition { name = "raining", display_name = "Not raining", value_type = "bool", reversed = true });
            world_conditions.Add(new Condition { name = "thundering", display_name = "Thundering", value_type = "bool" });
            world_conditions.Add(new Condition { name = "thundering", display_name = "Not thundering", value_type = "bool" });

            world_conditions.Add(new Condition
            {
                name = "world_mob_count",
                display_name = "The number of mobs in the world",
                value_type = "range",
                subvalue_type = "mob_type"
            });
            world_conditions.Add(new Condition
            {
                name = "chunk_mob_count",
                display_name = "The number of mobs in the same chunk",
                value_type = "range",
                subvalue_type = "mob_type"
            });
            world_conditions.Add(new Condition
            {
                name = "region_mob_count",
                display_name = "The number of mobs in a certain region",
                value_type = "range",
                subvalue_type = "mob_type, regions"
            });


            world_conditions.Add(new Condition { name = "world_players", display_name = "The names of players in the world", value_type = "string", reversed = true });

            world_conditions_list.ItemsSource = world_conditions;

            #endregion

            #region mob conditions

            List<Condition> mob_conditions = new List<Condition>();
            mob_conditions.Add(new Condition { display_name = "Mob" });
            mob_conditions.Add(new Condition { name = "boss_mob", display_name = "Boss mob", value_type ="bool" });
            mob_conditions.Add(new Condition { name = "not_boss_mob", display_name = "Not boss mob", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "spawn_type", display_name = "Spawn type", value_type = "string", subvalue_type = "spawn_type" });
            mob_conditions.Add(new Condition { name = "remaining_lifetime", display_name = "Remaining lifetime", value_type = "range" });
            mob_conditions.Add(new Condition { name = "death_cause", display_name = "Death cause", value_type = "string", subvalue_type = "damage_cause" });
            mob_conditions.Add(new Condition { name = "mob_ages", display_name = "Mob ages", value_type = "range" });
            mob_conditions.Add(new Condition { name = "wool_colour", display_name = "Wool colour", value_type = "string", subvalue_type = "sheep" });
            mob_conditions.Add(new Condition { name = "sheared", display_name = "Sheared", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_sheared", display_name = "Not Sheared", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "ocelot_type", display_name = "Ocelot type", value_type = "string", subvalue_type = "ocelot" });
            mob_conditions.Add(new Condition { name = "saddled", display_name = "Saddled", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_saddled", display_name = "Not saddled", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "powered", display_name = "Powered", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_powered", display_name = "Not powered", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "angry", display_name = "Angry", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_angry", display_name = "Not angry", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "tamed", display_name = "Tamed", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_tamed", display_name = "Not tamed", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "villager_type", display_name = "Villager type", value_type = "string", subvalue_type = "villager" });           
            mob_conditions.Add(new Condition { name = "mob_standing_on", display_name = "Mob standing on", value_type = "string", subvalue_type = "item_type" });
            mob_conditions.Add(new Condition { name = "killed_by_player", display_name = "Killed by a player", value_type = "bool" });
            mob_conditions.Add(new Condition { name = "not_killed_by_player", display_name = "Not killed by a player", value_type = "bool" });
            mob_conditions_list.ItemsSource = mob_conditions;

            #endregion

            #region player conditions

            List<Condition> player_conditions = new List<Condition>();
            player_conditions.Add(new Condition { display_name = "Player" });
            player_conditions.Add(new Condition { name = "killed_player_names", display_name = "Killed player names", value_type = "string" });
            player_conditions.Add(new Condition { name = "player_permissions", display_name = "Player permissions", value_type = "string" });
            player_conditions.Add(new Condition { name = "online_player_count", display_name = "Online player count", value_type = "range" });
            player_conditions.Add(new Condition { name = "server_players", display_name = "Online player names", value_type = "string" });
            player_conditions.Add(new Condition { name = "player_money", display_name = "Player money", value_type = "range" });
            player_conditions.Add(new Condition { name = "player_names", display_name = "Player names", value_type = "string" });
            player_conditions.Add(new Condition { name = "player_standing_on", display_name = "Player standing on", value_type = "string", subvalue_type = "item_type" });
            player_conditions_list.ItemsSource = player_conditions;

            #endregion            

            /* mob within
             * moon phase
     area_mob_count
player_holding
player_wearing
player_items*/
        }

        private void add_condition_group(object sender, Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = Utils.get_dropped_item(e);

            if (dropped.First().Item is Condition_group) return;

            Mobs mobs = MainPage.mobs;// (Mobs)DataContext;
           // if (mobs == null) mobs = new Mobs();
            if (mobs.condition_group_pool== null) mobs.condition_group_pool = new ObservableCollection<Condition_group>();
            mobs.condition_group_pool.Add(new Condition_group { id = Guid.NewGuid().ToString() });
        }

        private void adding_condition(object sender, Microsoft.Windows.DragEventArgs e)
        {
            e.Effects = Utils.block_bin_moving(e);
            e.Handled = true;
        }

        private void add_condition(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex != 0)
            {
                Condition c = (Condition)cb.SelectedItem;
                Condition c2 = new Condition
                {
                    name = c.name,
                    display_name = c.display_name,
                    value_type = c.value_type,
                    subvalue_type = c.subvalue_type,
                    time_type = c.time_type,
                    mob_type = c.mob_type,
                    coordinate_type = c.coordinate_type,
                    reversed = c.reversed
                };
                if (c2.value_type == "bool") c2.condition_value = "Yes";
                Condition_group cg = (Condition_group)condition_group_list.SelectedItem;
                //if (cg.conditions == null) cg.conditions = new ObservableCollection<Condition>();
                
                cg.conditions.Add(c2);
                cb.SelectedIndex = 0;
            }
        }

        private void insert_value(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb != null && cb.SelectedIndex != 0 && cb.SelectedItem != null)
            {
                Condition condition = (Condition)cb.DataContext;
                if (condition.condition_value != null && condition.condition_value != "") condition.condition_value += ",";
                condition.condition_value += ((Base_type)cb.SelectedItem).name;
                cb.SelectedIndex = 0;
                cb.IsDropDownOpen = false;
            }
        }

        private void check_input(object sender, TextChangedEventArgs e)
        {
            Condition c = (Condition)(sender as TextBox).DataContext;
            if (c.value_type == "range" || c.value_type == "mob_type" || c.value_type == "time_type" || c.value_type == "coordinate_type")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = Regex.Replace(tb.Text.ToLower(), @"[^0-9toabvelw,.\x20]", String.Empty);
                tb.SelectionStart = tb.Text.Length;
            }
        }

        private void change_condition_type(object sender, RoutedEventArgs e)
        {
            Condition c = (Condition)(sender as Button).DataContext;
            c.reversed = !c.reversed;
        }
    }
}
