using System;

namespace FoodChoice
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
