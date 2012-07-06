using System.Xml.Serialization;

namespace me.coldandtired.mcg.Models
{
    public class Data_type : Base_type
    {        
        private string _data_type = "";       
        [XmlAttribute]
        public string data_type
        {
            get { return _data_type; }

            set
            {
                _data_type = value;
                OnPropertyChanged("data_type");
            }
        }
    }
}
