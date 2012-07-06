using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class World_types : List<Base_type>
    {
        public World_types()
        {
            Add(new Base_type { display_name = "Insert type" });
            Add(new Base_type { display_name = "Normal", name = "normal" });
            Add(new Base_type { display_name = "Nether", name = "nether" });
            Add(new Base_type { display_name = "The End", name = "the_end" });
        }
    }
}
