using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Damage_types : List<Base_type>
    {
        public Damage_types()
        {
            Add(new Base_type { display_name = "Insert cause" });
            Add(new Base_type { name = "block_explosion", display_name = "Block Explosion" });
            Add(new Base_type { name = "contact", display_name = "Contact" });
            Add(new Base_type { name = "custom", display_name = "Custom" });
            Add(new Base_type { name = "drowning", display_name = "Drowning" });
            Add(new Base_type { name = "entity_attack", display_name = "Attack" });
            Add(new Base_type { name = "entity_explosion", display_name = "Entity explosion" });
            Add(new Base_type { name = "fall", display_name = "Fall" });
            Add(new Base_type { name = "fire", display_name = "Fire" });
            Add(new Base_type { name = "fire_tick", display_name = "Fire tick" });
            Add(new Base_type { name = "lava", display_name = "Lava" });
            Add(new Base_type { name = "lightning", display_name = "Lightning" });
            Add(new Base_type { name = "magic", display_name = "Magic" });
            Add(new Base_type { name = "melting", display_name = "Melting" });
            Add(new Base_type { name = "poison", display_name = "Poison" });
            Add(new Base_type { name = "projectile", display_name = "Projectile" });
            Add(new Base_type { name = "starvation", display_name = "Starvation" });
            Add(new Base_type { name = "suffocation", display_name = "Suffocation" });
            Add(new Base_type { name = "suicide", display_name = "Suicide" });
            Add(new Base_type { name = "void", display_name = "Void" });
        }
    }
}