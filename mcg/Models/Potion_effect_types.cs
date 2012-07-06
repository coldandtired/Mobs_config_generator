using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Potion_effect_types : List<Base_type>
    {
        public Potion_effect_types()
        {
            Add(new Base_type { name = "BLINDNESS", display_name = "Blindness" });
            Add(new Base_type { name = "CONFUSION", display_name = "Confusion" });
            Add(new Base_type { name = "DAMAGE_RESISTANCE", display_name = "Increased damage resistance" });
            Add(new Base_type { name = "FAST_DIGGING", display_name = "Increased digging speed" });
            Add(new Base_type { name = "FIRE_RESISTANCE", display_name = "Increased fire resistance" });
            Add(new Base_type { name = "HARM", display_name = "Harm" });
            Add(new Base_type { name = "HEAL", display_name = "Healing" });
            Add(new Base_type { name = "HUNGER", display_name = "Increased hunger" });
            Add(new Base_type { name = "INCREASE_DAMAGE", display_name = "Increased attack" });
            Add(new Base_type { name = "JUMP", display_name = "Increased jump height" });
            Add(new Base_type { name = "POISON", display_name = "Damage over time" });
            Add(new Base_type { name = "REGENERATION", display_name = "Health regeneration" });
            Add(new Base_type { name = "SLOW", display_name = "Decreased movmement speed" });
            Add(new Base_type { name = "SLOW_DIGGING", display_name = "Decreased digging speed" });
            Add(new Base_type { name = "SPEED", display_name = "Increased movement speed" });
            Add(new Base_type { name = "WATER_BREATHING", display_name = "Underwater breathing" });
            Add(new Base_type { name = "WEAKNESS", display_name = "Decreased attack" });
        }
    }
}
