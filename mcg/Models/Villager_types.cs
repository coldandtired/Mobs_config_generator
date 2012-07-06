using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class Villager_types : List<Base_type>
    {
        public Villager_types()
        {
            Add(new Base_type { display_name = "Insert type" });
            Add(new Base_type { display_name = "Blacksmith", name = "blacksmith" });
            Add(new Base_type { display_name = "Butcher", name = "butcher" });
            Add(new Base_type { display_name = "Farmer", name = "farmer" });
            Add(new Base_type { display_name = "Librarian", name = "librarian" });
            Add(new Base_type { display_name = "Priest", name = "priest" });
        }

        public void insert_extra_values()
        {
            Insert(1, new Base_type { display_name = "Default", name = "default" });
            Insert(2, new Base_type { display_name = "Random", name = "random" });
        }
    }
}
