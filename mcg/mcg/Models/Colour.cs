namespace me.coldandtired.mcg.Models
{
    public class Colour : Base_type
    {
        private string _colour_name;
        private string _colour_id;

        public string colour_name
        {
            get { return _colour_name; }

            set
            {
                _colour_name = value;
                OnPropertyChanged("colour_name");
            }
        }

        public string colour_id
        {
            get { return _colour_id; }

            set
            {
                _colour_id = value;
                OnPropertyChanged("colour_id");
            }
        }
    }
}
