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

        private IRepository _repository = new Repository();
        public void Display()
        {
               Console.WriteLine("Enter Restaurant Information");
            
            Console.WriteLine("<5> Name - " + NewRestaurant.Name);
            Console.WriteLine("<4> Phone - " + NewRestaurant.Phone);
            Console.WriteLine("<3> Address - " + NewRestaurant.Address);
            //Console.WriteLine("<2> Rating - " + NewRestaurant.Rating);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    _repository.AddRestaurant(NewRestaurant);
                    Console.WriteLine("----New Restaurant Added----");
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a Rating: ");
                    //NewRestaurant.Rating = Convert.ToInt32(Console.ReadLine());
                    return "Create Restaurant";
                case "3":
                    Console.Write("Please enter a address: ");
                    NewRestaurant.Address = Console.ReadLine();
                    return "Create Restaurant";
                case "4":
                    Console.Write("Please enter a phone: ");
                    NewRestaurant.Phone = Convert.ToInt64(Console.ReadLine());
                    return "Create Restaurant";
                case "5":
                    Console.Write("Please enter a name: ");
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
