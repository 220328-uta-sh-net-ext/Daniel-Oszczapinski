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
        public string Phone { get; set; }
        public string Address { get; set; }
        //public int Rating { get; set; }
       /* private List<Info> _infoes;
        public List<Info> Infoes { 
            get 
            {
                return _infoes;
            } 
            set 
            {
                if (value.Count <=5)
                    _infoes = value;
                else
                    throw new Exception("Connot have a more than a rating of 5.");
            }
        }*/

        public Restaurant()
        {
            Name = "Restaurant Name";
            Address = "Restaurant Address";
            Phone = "9994448888";

            /*_infoes = new List<Info>()
            {
                new Info()
            };*/
        }
        public override string ToString()
        {
            return $"Restaurant Name: {Name}\nAddress: {Address}\nPhone Number: {Phone}\n";
        }
    }
}
