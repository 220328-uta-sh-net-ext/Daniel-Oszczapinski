using RestaurantDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class FilteredMenu : IMenu
    {
        private IRepository repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the restaurant database");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <2> By Average Rating");
            
            Console.WriteLine("Press <0> Go Back");
        }

        public string UserChoice()
        {
            
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    Console.WriteLine("Please enter a name for the restaurant: ");
                    string name = Console.ReadLine();
                    var restaurants = repository.GetReviewInfo();
                    var filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(name)).ToList();
                    foreach (var results in filteredRestaurants)
                    {
                        
                            Console.WriteLine("=================");
                            Console.WriteLine(results.ToString());

                            return "MainMenu";
                        
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter a name for the restaurant: ");
                    string rating = Console.ReadLine();
                    var resultsTwo = repository.SearchRestaurants(rating);
                    if (resultsTwo.Count() > 0)
                    {
                        foreach (var result in resultsTwo)
                        {
                            Console.WriteLine("=================");
                            Console.WriteLine(result.ToString());
                            return "MainMenu";
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with search string {rating} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchRestaurant";
            }
        }
    }
}
