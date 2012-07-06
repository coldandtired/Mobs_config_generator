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

namespace me.coldandtired.mcg.Models
{
    public class Drop : Notify
    {
        private string _message = "Nothing (cancelled drops)";
        private string _quantity = "1";
        private string _name = "0";
        private string _chance = "above 0";
        private bool _add_all_enchantments = true;
        private string _data = "0";
        private bool _replace = false;
        //private Item_enchantments _item_enchantments = null;
        [XmlAttribute]
        public string id { get; set; }

        [XmlAttribute]
        public bool has_enchantments { get; set; }

        [XmlAttribute]
        public string message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("message");
            }
        }

        [XmlAttribute]
        public string quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("quantity");
            }
        }

        [XmlAttribute]
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                data = "0";
                OnPropertyChanged("name");
            }
        }

        [XmlAttribute]
        public string chance
        {
            get { return _chance; }
            set
            {
                _chance = value;
                OnPropertyChanged("chance");
            }
        }

        [XmlAttribute]
        public bool add_all_enchantments
        {
            get { return _add_all_enchantments; }
            set
            {
                _add_all_enchantments = value;
                OnPropertyChanged("add_all_enchantments");
            }
        }

        [XmlAttribute]
        public string data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged("data");
            }
        }

       /* public Item_enchantments item_enchantments
        {
            get { return _item_enchantments; }
            set
            {
                _item_enchantments = value;
                OnPropertyChanged("item_enchantments");
            }
        }*/

        [XmlAttribute]
        public bool replace
        {
            get { return _replace; }

            set
            {
                _replace = value;
                OnPropertyChanged("replace");
            }
        }
    }
}
