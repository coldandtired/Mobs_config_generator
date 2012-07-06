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
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace me.coldandtired.mcg.Models
{
    public class Mob : Notify
    {
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string display_name { get; set; }

        private ObservableCollection<Outcome> _outcomes;
        public ObservableCollection<Outcome> outcomes
        {
            get { return _outcomes; }
            set
            {
                _outcomes = value;
                OnPropertyChanged("outcomes");
            }
        }
      //  Outcome base_outcome;
    }
}
