using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class AverageRating
    {  
        public AverageRating() { }
        public AverageRating(string name, double average, int restId)
        {
            Average = 0;
            RestId = 0;

        }
            public int RestId { get; set; }
        public double Average { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nAverage: {this.Average}";
        }

    }
}
