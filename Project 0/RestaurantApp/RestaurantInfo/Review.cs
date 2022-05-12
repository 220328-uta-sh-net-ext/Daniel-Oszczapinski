using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class Review
    {

        public Review() { }

        //Example of constructor overloading
        public Review(int rating)
        {
            this.Rating = rating;
        }

        public Review(double rating, string note,  string name, string username, double average, int RestId)
        {
            this.Rating = rating;
            this.Note = note;
            this.Name = name;
            this.UserName = username;
            this.Average = average;
            this.RestId = RestId;
        }

        public int ReviewId { get; set; }
        private int restId;
        public int RestId
        {
            get => restId;

            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    restId = value;
                }
                else
                {
                    throw new Exception("The Id cannot be empty");
                }
            }
        }
        
     
       
        public double Average { get; set; }
        private double _rating;
        public double Rating
        {
            get => _rating;
            //For the setter, we are checking that the rating is between 1 and 5
            set
            {
                if (value <= 0 || value > 5)
                {
                    throw new Exception("Rating must be between 1 and 5");
                }
                this._rating = value;
            }
        }
        public string Note { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        //override Review's ToString Method for me here
        //That outputs $"Rating: {review.Rating} \t Note: {review.Note}"

        public override string ToString()
        {
            return $"Name:{this.Name}\tRating: {this.Rating}\t Note: {this.Note}\nAverage: {this.Average}";
        }

    }
}
