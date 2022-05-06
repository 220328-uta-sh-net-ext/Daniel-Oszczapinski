using RestaurantDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    /// <summary>
    /// Filtered menu 
    /// </summary>
    internal class FilteredMenu : IMenu
    {
        //private IRepository repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the restaurant database");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <2> By Address");
            Console.WriteLine("Press <3> By ZipCode");
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
                    //var restaurants = repository.GetRestaurantInfo();
                   /* var filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(name)).ToList();
                    foreach (var results in filteredRestaurants)
                    {
                        
                            Console.WriteLine("=================");
                            Console.WriteLine(results.ToString());

                            
                        
                    }*/
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter an Address for the restaurant: ");
                    var findAddress = Console.ReadLine();
                    //var searchAddress = repository.GetRestaurantInfo();
                    //var filteredAddress = searchAddress.Where(restaurant => restaurant.Address.Contains(findAddress)).ToList();
                   // foreach (var results in filteredAddress)
                   // {

                    //    Console.WriteLine("=================");
                    //    Console.WriteLine(results.ToString());

                        

                   // }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                case "3":
                    Console.WriteLine("Please enter an ZipCode for the restaurant: ");
                    var zipCode = Console.ReadLine();
                    //var searchZipCode = repository.GetRestaurantInfo();
                    //var filteredZipCode = searchZipCode.Where(restaurant => restaurant.ZipCode.Contains(zipCode)).ToList();
                    //foreach (var results in filteredZipCode)
                   // {

                     //   Console.WriteLine("=================");
                    //    Console.WriteLine(results.ToString());

                        

                   // }
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
