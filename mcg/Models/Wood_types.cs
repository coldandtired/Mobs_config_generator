
using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class Wood_types : List<Base_type>
    {
        public Wood_types()
        {
            Add(new Base_type { display_name = "Insert type" });
          /*  if (!condition)
            {
                types.Add(new Base_type { display_name = "Default", name = "default" });
                types.Add(new Base_type { display_name = "Random", name = "random" });
            }*/
            Add(new Base_type { display_name = "Pine", name = "1" });
            Add(new Base_type { display_name = "Birch", name = "2" });
            Add(new Base_type { display_name = "Jungle", name = "3" });
        }
    }
}
