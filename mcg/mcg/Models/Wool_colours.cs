using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Wool_colours : List<Colour>
    {
        public Wool_colours()
        {
            Add(new Colour { display_name = "Insert colour" });
            Add(new Colour { display_name = "Black", colour_name = "Black", name = "15" });
            Add(new Colour { display_name = "Black", colour_name = "Black", name = "15" });
            Add(new Colour { display_name = "Blue", colour_name = "Blue", name = "11" });
            Add(new Colour { display_name = "Brown", colour_name = "Brown", name = "12" });
            Add(new Colour { display_name = "Cyan", colour_name = "Cyan", name = "9" });
            Add(new Colour { display_name = "Gray", colour_name = "Gray", name = "7" });
            Add(new Colour { display_name = "Green", colour_name = "Green", name = "13" });
            Add(new Colour { display_name = "Light Blue", colour_name = "LightBlue", name = "3" });
            Add(new Colour { display_name = "Lime", colour_name = "Lime", name = "5" });
            Add(new Colour { display_name = "Magenta", colour_name = "Magenta", name = "2" });
            Add(new Colour { display_name = "Orange", colour_name = "Orange", name = "1" });
            Add(new Colour { display_name = "Pink", colour_name = "Pink", name = "6" });
            Add(new Colour { display_name = "Purple", colour_name = "Purple", name = "10" });
            Add(new Colour { display_name = "Red", colour_name = "Red", name = "14" });
            Add(new Colour { display_name = "Silver", colour_name = "Silver", name = "8" });
            Add(new Colour { display_name = "White", colour_name = "White", name = "0" });
            Add(new Colour { display_name = "Yellow", colour_name = "Yellow", name = "4" });
        }

        public void insert_extra_values()
        {
            Insert(1, new Colour { display_name = "Default", name = "default" });
            Insert(2, new Colour { display_name = "Random", name = "random" });
        }
    }
}
