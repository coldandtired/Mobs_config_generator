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
using System.Collections.ObjectModel;

namespace me.coldandtired.mcg.Models
{
    public class Potion_effect_group : Notify
    {
        public bool all_effects { get; set; }
        public string id { get; set; }

        private ObservableCollection<Potion_effect> _potion_effects;
        public ObservableCollection<Potion_effect> potion_effects
        {
            get { return _potion_effects; }
            set
            {
                _potion_effects = value;
                OnPropertyChanged("potion_effects");
            }

        }
    }
}
