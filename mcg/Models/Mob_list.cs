using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Mob_list : List<Base_type>
    {
        public Mob_list()
        {
            Add(new Base_type { name = "BLAZE", display_name = "Blaze" });
            Add(new Base_type { name = "CAVE_SPIDER", display_name = "Cave Spider" });
            Add(new Base_type { name = "CHICKEN", display_name = "Chicken" });
            Add(new Base_type { name = "COW", display_name = "Cow" });
            Add(new Base_type { name = "CREEPER", display_name = "Creeper" });
            Add(new Base_type { name = "ENDER_DRAGON", display_name = "Ender Dragon" });
            Add(new Base_type { name = "ENDERMAN", display_name = "Enderman" });
            Add(new Base_type { name = "GHAST", display_name = "Ghast" });
            Add(new Base_type { name = "GIANT", display_name = "Giant" });
            Add(new Base_type { name = "IRON_GOLEM", display_name = "Iron Golem" });
            Add(new Base_type { name = "MAGMA_CUBE", display_name = "Magma Cube" });
            Add(new Base_type { name = "MUSHROOM_COW", display_name = "Mooshroom" });
            Add(new Base_type { name = "OCELOT", display_name = "Ocelot" });
            Add(new Base_type { name = "PIG", display_name = "Pig" });
            Add(new Base_type { name = "PIG_ZOMBIE", display_name = "Pig Zombie" });
            Add(new Base_type { name = "PLAYER", display_name = "Player" });
            Add(new Base_type { name = "SHEEP", display_name = "Sheep" });
            Add(new Base_type { name = "SILVERFISH", display_name = "Silverfish" });
            Add(new Base_type { name = "SKELETON", display_name = "Skeleton" });
            Add(new Base_type { name = "SLIME", display_name = "Slime" });
            Add(new Base_type { name = "SNOWMAN", display_name = "Snowman" });
            Add(new Base_type { name = "SPIDER", display_name = "Spider" });
            Add(new Base_type { name = "SQUID", display_name = "Squid" });
            Add(new Base_type { name = "VILLAGER", display_name = "Villager" });
            Add(new Base_type { name = "WOLF", display_name = "Wolf" });
            Add(new Base_type { name = "ZOMBIE", display_name = "Zombie" });
            Add(new Base_type { name = "CUSTOM", display_name = "Custom" });
        }  
    }
}
