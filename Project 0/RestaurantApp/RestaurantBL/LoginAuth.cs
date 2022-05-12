using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBL;
using RestaurantDL;
using RestaurantInfo;
namespace RestaurantBL
{
    public static class Choice
    {
        public static string FirstChoice = "NoChoice";
        public static string SecondChoice = "Registered";
        public static string ThirdChoice = "Admin";
    }
    public class LoginAuth
    {
        public LoginAuth()
        { }


        public string login(string choice,string EmailId, string Pass)
        {
            if (choice == "Admin")
            {
                var email = "Admin@gmail.com";
                var passowrd = "Admin";
                if (EmailId == email && Pass == passowrd)
                {
                    Console.WriteLine("**login Success**");
                    return "Login Success";
                }
            }
            else if (choice == "User")
            {
                SqlRepository user = new SqlRepository();
                var Users = user.GetUsersInfo();

                foreach (var User in Users)
                {
                    Console.WriteLine("Entered Email: "+ User.Email);
                    Console.WriteLine("Entered Password "+ User.Password);
                    if (User.Email == EmailId || User.Password == Pass)
                    {
                        Console.Clear();
                        Choice.ThirdChoice = User.Name;
                        return "Login Success";
                    }

                }
                return "Login Failed";

            }
           return "Login Failed";

        }




    }
}
