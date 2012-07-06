using System.Collections.Generic;
namespace me.coldandtired.mcg.Models
{
    public class Spawn_types : List<Base_type>
    {
        public Spawn_types()
        {
            Add(new Base_type { display_name = "Insert type" });
            Add(new Base_type { display_name = "Autospawned", name = "autospawned" });
            Add(new Base_type { display_name = "Breeding", name = "breeding" });
            Add(new Base_type { display_name = "Build irongolem", name = "build_irongolem" });
            Add(new Base_type { display_name = "Build snowman", name = "build_snowman" });
            Add(new Base_type { display_name = "Chunk gen", name = "chunk_gen" });
            Add(new Base_type { display_name = "Custom", name = "custom" });
            Add(new Base_type { display_name = "Egg", name = "egg" });
            Add(new Base_type { display_name = "Jockey", name = "jockey" });
            Add(new Base_type { display_name = "Lightning", name = "lightning" });
            Add(new Base_type { display_name = "Natural", name = "natural" });
            Add(new Base_type { display_name = "Spawner", name = "spawner" });
            Add(new Base_type { display_name = "Spawner egg", name = "spawner_egg" });
            Add(new Base_type { display_name = "Village defense", name = "village_defense" });
            Add(new Base_type { display_name = "Village invasion", name = "village_invasion" });
        }
    }
}
