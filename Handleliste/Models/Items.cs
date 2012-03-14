using System;

namespace Handleliste.Models
{
    public class Item
    {
        public Item()
        {
            InShoppingCart = false;
        }

        public Item(string name) : this()
        {
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public string CreatedWhen
        {
            get
            {
                var minutesSinceCreated = (int)(DateTime.Now - TimestampCreated).TotalMinutes;

                if (minutesSinceCreated == 0)
                    return "nå";

                if (minutesSinceCreated < 60)
                    return string.Format("for {0} min siden", minutesSinceCreated);

                var daysSinceCreated = (int) (DateTime.Now.Date - TimestampCreated.Date).TotalDays;

                var wasCreatedToday = daysSinceCreated == 0;
                
                if (wasCreatedToday)
                    return "i dag";
                
                return string.Format("for {0} dager siden", daysSinceCreated);
            }
            set { }
        }

        public bool InShoppingCart { get; set; }
        public DateTime TimestampCreated { get; set; }
    }
}