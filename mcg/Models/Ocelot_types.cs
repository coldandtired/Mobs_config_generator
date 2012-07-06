using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class Ocelot_types : List<Base_type>
    {
        public Ocelot_types()
        {
            Add(new Base_type { display_name = "Insert type" });
            Add(new Base_type { display_name = "Black cat", name = "BLACK_CAT" });
            Add(new Base_type { display_name = "Red cat", name = "RED_CAT" });
            Add(new Base_type { display_name = "Siamese cat", name = "SIAMESE_CAT" });
            Add(new Base_type { display_name = "Wild ocelot", name = "WILD_OCELOT" });
        }

        public void insert_extra_values()
        {
            Insert(1, new Base_type { display_name = "Default", name = "default" });
            Insert(2, new Base_type { display_name = "Random", name = "random" });
        }
    }
}
