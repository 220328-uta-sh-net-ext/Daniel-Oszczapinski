using RestaurantDL;
using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class AddUser :IMenu
    {
        private static User NewUser = new User();

        private IRepository _repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Enter User Information");

            Console.WriteLine("<4> Name - " + NewUser.Name);
            Console.WriteLine("<3> Email - " + NewUser.Email);
            Console.WriteLine("<2> Password - " + NewUser.Password);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    Log.Information("Return to Main Menu");
                    return "MainMenu";
                case "1":
                    Log.Information("Save all Informaiton");
                    _repository.AddUser(NewUser);
                    Console.WriteLine("----New User Added----");
                    return "MainMenu";
                case "2":
                    Log.Information("Adding Password - " + NewUser.Password);
                    Console.Write("Please enter a password: ");
                    NewUser.Password = Console.ReadLine();
                    return "Create User";
                case "3":
                    Log.Information("Adding Email - " + NewUser.Email);
                    Console.Write("Please enter a email: ");
                    NewUser.Email = Convert.ToString(Console.ReadLine());
                    return "Create User";
                case "4":
                    Log.Information("Adding Name - " + NewUser.Name);
                    Console.Write("Please enter a name: ");
                    NewUser.Name = Console.ReadLine();
                    return "Create User";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }
}
