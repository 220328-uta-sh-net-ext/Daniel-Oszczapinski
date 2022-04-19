using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public class Repository : IRepository
    {
        private string filePath = "../RestaurantDL/Database";
        private string jsonString;
        public Restaurant AddRestaurant(Restaurant rest)
        {
            var restuaurants = GetRestaurantInfo();
            restuaurants.Add(rest);
        }

        public List<Repository> GetRestaurantInfo()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Restaurant.json");
            }
            catch (DirectoryNotFoundException ex)
            { 
               Console.WriteLine("Please check the path, "+ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
            {
                return JsonSerializer.Deserialize<List<Repository>>(jsonString);
            }
            else
            {
                return null;
            }
        }

       
    }
}
