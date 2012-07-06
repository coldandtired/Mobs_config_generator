using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Coordinate_types : List<Base_type>
    {
        public Coordinate_types()
        {
            Add(new Base_type { name = "x", display_name = "X co-ordinate" });
            Add(new Base_type { name = "y", display_name = "Y co-ordinate" });
            Add(new Base_type { name = "z", display_name = "Z co-ordinate" });
        }
    }
}
