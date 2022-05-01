using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantInfo
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public User() { }
        public User(string name)
        {
            this.Name = name;
           
        }
        public User(string email, string password)
        {
            
            this.Email = email;

            this.Password = password;
        }
        public override string ToString()
        {
            return $"UserName: {this.Name}\nAddress: {this.Email}\nPhone Number: {this.Password}";
        }

    }
}
