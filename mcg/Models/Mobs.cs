using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace me.coldandtired.mcg.Models
{
    public class Mobs : Notify
    {
        [XmlAttribute]
        public string version = "0.9";

        private ObservableCollection<Condition_group> _condition_group_pool;
        public ObservableCollection<Condition_group> condition_group_pool
        {
            get { return _condition_group_pool; }
            set
            {
                _condition_group_pool = value;
                OnPropertyChanged("condition_group_pool");
            }
        }

        private ObservableCollection<Drop> _drops_pool;
        public ObservableCollection<Drop> drops_pool
        {
            get { return _drops_pool; }
            set
            {
                _drops_pool = value;
                OnPropertyChanged("drops_pool");
            }
        }

        private ObservableCollection<Potion_effect_group> _potion_effect_pool;
        public ObservableCollection<Potion_effect_group> potion_effect_pool
        {
            get { return _potion_effect_pool; }
            set
            {
                _potion_effect_pool = value;
                OnPropertyChanged("potion_effect_pool");
            }

        }

        private ObservableCollection<Mob> _mob_pool;
        public ObservableCollection<Mob> mob_pool
        {
            get { return _mob_pool; }
            set
            {
                _mob_pool = value;
                OnPropertyChanged("mob_pool");
            }
        }

        private ObservableCollection<string> _active_mobs;
        public ObservableCollection<string> active_mobs
        {
            get { return _active_mobs; }
            set
            {
                _active_mobs = value;
                OnPropertyChanged("active_mobs");
            }
        }
    }
}
