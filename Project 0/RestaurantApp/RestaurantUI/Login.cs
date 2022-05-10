using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBL;
using RestaurantDL;
using RestaurantInfo;

namespace RestaurantUI
{
    internal class Login
    {
        public string UserInput(string FirstChoice)
        {
            User loginCheck = new();
            LoginAuth log = new();
            Console.WriteLine("Enter Email and Password\n");
        emailSelection:
            Console.WriteLine("Email is: ");
            loginCheck.Email = Console.ReadLine();
            if (string.IsNullOrEmpty(loginCheck.Email))
            {
                Console.WriteLine("Email should not be blank\n");
                goto emailSelection;
            }
        passSelection:
            Console.WriteLine("Password is: ");
            loginCheck.Password = Console.ReadLine();
            if(string.IsNullOrEmpty(loginCheck.Password))
                {
                Console.WriteLine("Password can not be blank");
                goto passSelection;
            
            }
            var result = log.login(FirstChoice, loginCheck.Email, loginCheck.Password);
            return result;
        }
    }
}
