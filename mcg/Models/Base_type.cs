using System.Xml.Serialization;

namespace me.coldandtired.mcg.Models
{
    public class Base_type : Notify
    {
        private string _display_name;
        [XmlAttribute]
        public string display_name
        {
            get { return _display_name; }

            set
            {
                _display_name = value;
                OnPropertyChanged("display_name");
            }
        }

        private string _name;
        [XmlAttribute]
        public string name
        {
            get { return _name; }

            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }
    }
}
