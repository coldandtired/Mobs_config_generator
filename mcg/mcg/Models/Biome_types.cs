using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class Biome_types : List<Base_type>
    {
        public Biome_types()
        {
            Add(new Base_type { display_name = "Insert biome" });
            Add(new Base_type { display_name = "Beach", name = "beach" });
            Add(new Base_type { display_name = "Desert", name = "desert" });
            Add(new Base_type { display_name = "Desert hills", name = "desert_hills" });
            Add(new Base_type { display_name = "Extreme hills", name = "extreme_hills" });
            Add(new Base_type { display_name = "Forest", name = "forest" });
            Add(new Base_type { display_name = "Forest hills", name = "forest_hills" });
            Add(new Base_type { display_name = "Frozen ocean", name = "frozen_ocean" });
            Add(new Base_type { display_name = "Frozen river", name = "frozen_river" });
            Add(new Base_type { display_name = "Hell", name = "hell" });
            Add(new Base_type { display_name = "Ice desert", name = "ice_desert" });
            Add(new Base_type { display_name = "Ice mountains", name = "ice_mountains" });
            Add(new Base_type { display_name = "Ice plains", name = "ice_plains" });
            Add(new Base_type { display_name = "Jungle", name = "jungle" });
            Add(new Base_type { display_name = "Jungle hills", name = "jungle_hills" });
            Add(new Base_type { display_name = "Mushroom island", name = "mushroom_island" });
            Add(new Base_type { display_name = "Mushroom shore", name = "mushroom_shore" });
            Add(new Base_type { display_name = "Ocean", name = "ocean" });
            Add(new Base_type { display_name = "Plains", name = "plains" });
            Add(new Base_type { display_name = "Rainforest", name = "rainforest" });
            Add(new Base_type { display_name = "River", name = "river" });
            Add(new Base_type { display_name = "Savanna", name = "savanna" });
            Add(new Base_type { display_name = "Seasonal forest", name = "seasonal_forest" });
            Add(new Base_type { display_name = "Shrubland", name = "shrubland" });
            Add(new Base_type { display_name = "Sky", name = "sky" });
            Add(new Base_type { display_name = "Small mountains", name = "small_mountains" });
            Add(new Base_type { display_name = "Swampland", name = "swampland" });
            Add(new Base_type { display_name = "Taiga", name = "taiga" });
            Add(new Base_type { display_name = "Taiga hills", name = "taiga_hills" });
            Add(new Base_type { display_name = "Tundra", name = "tundra" });
        }
    }
}
