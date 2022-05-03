using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
using RestaurantInfo;
namespace RestaurantUI
{
    /// <summary>
    /// Adding Restaurant Menu
    /// </summary>
    public class AddRestaurantMenu : IMenu
    {
        private static Restaurant NewRestaurant = new Restaurant();

        private IRepository _repository = new SqlRepository();
        public void Display()
        {
               Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<1> Name - " + NewRestaurant.Name);
            Console.WriteLine("<2> State - " + NewRestaurant.State);
            Console.WriteLine("<3> City - " + NewRestaurant.City);
            Console.WriteLine("<4> Address - " + NewRestaurant.Address);
            Console.WriteLine("<5> Zipcode - " + NewRestaurant.ZipCode);
            Console.WriteLine("<6> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    Log.Information("Returning To Main Menu");
                    return "MainMenu";
                case "1":
                    Log.Information("Adding Restaurant Name - " + NewRestaurant.Name);
                    Console.Write("Please enter a Restaurant Name: ");
                    NewRestaurant.Name = Console.ReadLine();
                    return "Create Restaurant";
                case "2":
                    Log.Information("Addiing State - " + NewRestaurant.State);
                    Console.Write("Please enter a State: ");
                    NewRestaurant.State = Convert.ToString(Console.ReadLine());
                    return "Create Restaurant";
                case "3":
                    Log.Information("Adding City - " + NewRestaurant.City);
                    Console.Write("Please enter a City: ");
                    NewRestaurant.City = Console.ReadLine();
                    return "Create Restaurant";
                case "4":
                    Log.Information("Adding Address - " + NewRestaurant.Address);
                    Console.Write("Please enter a Address: ");
                    NewRestaurant.Address = Console.ReadLine();
                    return "Create Restaurant";
                case "5":
                    Log.Information("Adding Zipcode - " + NewRestaurant.ZipCode);
                    Console.Write("Please enter a Zipcode: ");
                    NewRestaurant.ZipCode = Console.ReadLine();
                    return "Create Restaurant";
                case "6":
                    Log.Information("Saving Information");
                    _repository.AddRestaurant(NewRestaurant);
                    Console.WriteLine("----New Restaurant Added----");
                    return "MainMenu";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
        
    }
}
