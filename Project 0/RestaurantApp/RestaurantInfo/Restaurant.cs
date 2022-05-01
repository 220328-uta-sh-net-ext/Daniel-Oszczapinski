using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class Restaurant
    {
        public Restaurant()
        {
            this.Reviews = new List<Review>();
        }
        public Restaurant(string name)
        {
            this.Reviews = new List<Review>();
            this._name = name;
        }

        /// <summary>
        /// Converting Restaurant table's data row into Restaurant Object
        /// </summary>
        /// <param name="row">a data row from Restaurant object, must have id, name, city, state columns</param>
        public Restaurant(DataRow row)
        {
            
            this.Name = row["Name"].ToString() ?? "";
            this.City = row["City"].ToString() ?? "";
            this.State = row["State"].ToString() ?? "";
        }

        

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                Regex pattern = new Regex("^[a-zA-Z0-9 !?']+$");
                if (string.IsNullOrWhiteSpace(value))
                {
                    //we're checking whether this string is null or whitespace
                    throw new Exception("Name can't be empty");
                }
                //even if the string is not null or white space,
                //we can still check for the name's validity by using RegEx (Regular Expression)
                //Regular Expression is a way to pattern match a string for a certain condition
                //it has a confusing syntax, so I recommend looking up language specific RegEx reference page to build one
                else if (!pattern.IsMatch(value))
                {
                    throw new Exception("Restaurant name can only have alphanumeric characters, white space, !, ?, and '.");
                }
                else
                {
                    this._name = value;
                }
            }
        }


        // //our own custom getter and setter for the private backing field
        // public string GetName() {
        //     return this._name;
        // }
        // public void SetName(string name)
        // {
        //     //input validation
        //     if(name == "")
        //     {
        //         Console.WriteLine("Name Cannot Be Empty");
        //     }
        //     this._name = name;
        // }

        // private string _city;

        public string City { get; set; }
        public string State { get; set; }
        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name} \nCity: {this.City} \nState: {this.State}";
        }

        /// <summary>
        /// Takes in Restaurant Table's DataRow and fills the columns with the Restaurant Instance's info
        /// </summary>
        /// <param name="row">Restaurant Table's DataRow pass by ref</param>
        public void ToDataRow(ref DataRow row)
        {
            row["Name"] = this.Name;
            row["City"] = this.City;
            row["State"] = this.State;
        }






        /*public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
      

        public Restaurant()
        {
            Name = "Restaurant Name";
            Address = "Restaurant Address";
            Phone = "9994448888";
        }
        public override string ToString()
        {
            return $"Restaurant Name: {Name}\nAddress: {Address}\nPhone Number: {Phone}\n";
        }*/
    }
}
