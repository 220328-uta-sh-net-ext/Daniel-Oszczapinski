using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Add { get; set; }
        public string Address { get; set; }
        private int _Rating;
        public int AverageRating { get 
            {
                return _Rating;
            } 
            set 
            {
                if (value > 0)
                    _Rating = value;
                else
                    throw new Exception("You cannot have a rating lower than 0.");
            }
        }

        public Restaurant()
        {
            Name = "Jimmy Johns";
            Address = "123 W Hollywood, California 70453";
            AverageRating = 0;

        }
    }
}
