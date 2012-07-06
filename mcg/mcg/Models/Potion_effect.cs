namespace me.coldandtired.mcg.Models
{
    public class Potion_effect
    {
        public string level { get; set; }
        public string duration { get; set; }
        public bool use_seconds { get; set; }
        public string name { get; set; }

        public Potion_effect()
        {
            level = "1";
            duration = "5";
            use_seconds = false;
            name = "BLINDNESS";
        }
    }
}