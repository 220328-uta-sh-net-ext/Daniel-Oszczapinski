using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
using RestaurantInfo;
namespace RestaurantUI
{

    public class AddRestaurantMenu : IMenu
    {
        private static Restaurant NewRestaurant = new Restaurant();

        private IRepository _repository = new SqlRepository();
        public void Display()
        {
               Console.WriteLine("Enter Restaurant Information");
            
            Console.WriteLine("<4> Name - " + NewRestaurant.Name);
            Console.WriteLine("<3> City - " + NewRestaurant.City);
            Console.WriteLine("<2> State - " + NewRestaurant.State);
            Console.WriteLine("<1> Save");
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
                    Log.Information("Saving Information");
                    _repository.AddRestaurant(NewRestaurant);
                    Console.WriteLine("----New Restaurant Added----");
                    return "MainMenu";
                case "2":
                    Log.Information("Adding State - " + NewRestaurant.State);
                    Console.Write("Please enter a State: ");
                    NewRestaurant.State = Console.ReadLine();
                    return "Create Restaurant";
                case "3":
                    Log.Information("Addiing City - " + NewRestaurant.City);
                    Console.Write("Please enter a City: ");
                    NewRestaurant.City = Convert.ToString(Console.ReadLine());
                    return "Create Restaurant";
                case "4":
                    Log.Information("Adding Restaurant Name - " + NewRestaurant.Name);
                    Console.Write("Please enter a Restaurant Name: ");
                    NewRestaurant.Name = Console.ReadLine();
                    return "Create Restaurant";
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
