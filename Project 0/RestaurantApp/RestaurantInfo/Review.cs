using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class Review
    {

        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public Review() { }

        public Review(int rating)
        {
            this.Rating = rating;
        }

        private int _rating;
        public int Rating 
        { 
            get => _rating;

            set 
            {
                if(value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Rating must be between 1 and 5!");
                }
                this._rating = value;
            }
        
        }

        public override string ToString()
        {
            return $"Rating: {this.Rating}";
        }













    }
}
