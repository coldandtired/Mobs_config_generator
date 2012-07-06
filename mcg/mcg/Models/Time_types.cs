using System.Collections.Generic;

namespace me.coldandtired.mcg.Models
{
    public class Time_types : List<Base_type>
    {
        public Time_types()
        {
            Add(new Base_type { name = "seconds", display_name = "Seconds" });
            Add(new Base_type { name = "minutes", display_name = "Minutes" });
            Add(new Base_type { name = "hours", display_name = "Hours" });
            Add(new Base_type { name = "days", display_name = "Days" });
            Add(new Base_type { name = "dates", display_name = "Dates" });
            Add(new Base_type { name = "months", display_name = "Months" });
            Add(new Base_type { name = "years", display_name = "Years" });
            Add(new Base_type { name = "month_weeks", display_name = "Week of month" });
            Add(new Base_type { name = "year_days", display_name = "Day of year" });
            Add(new Base_type { name = "year_weeks", display_name = "Week of year" });
        }
    }
}
