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
    public class Condition_group : Notify
    {
        [XmlAttribute]
        public string id { get; set; }

        private ObservableCollection<Condition> _conditions = new ObservableCollection<Condition>();
        public ObservableCollection<Condition> conditions
        {
            get { return _conditions; }
            set
            {
                _conditions = value;
                OnPropertyChanged("conditions");
            }
        }
    }
}
