using System.Xml.Serialization;

namespace me.coldandtired.mcg.Models
{
    public class Condition : Base_type
    {
        private string _value_type;
        [XmlAttribute]
        public string value_type
        {
            get { return _value_type; }

            set
            {
                _value_type = value;
                OnPropertyChanged("value_type");
            }
        }

        [XmlAttribute]
        public string subvalue_type { get; set; }

        [XmlAttribute]
        public string regions { get; set; }

        [XmlAttribute]
        public string mob_type { get; set; }

        [XmlAttribute]
        public string coordinate_type { get; set; }

        [XmlAttribute]
        public string time_type { get; set; }

        private string _condition_value;
        [XmlAttribute]
        public string condition_value
        {
            get { return _condition_value; }

            set
            {
                _condition_value = value;
                OnPropertyChanged("condition_value");
            }
        }

        [XmlAttribute]
        public bool reversed { get; set; }
    }
}
