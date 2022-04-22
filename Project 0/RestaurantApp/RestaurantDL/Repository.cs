using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantDL
{
    public class Repository : IRepository
    {
        private string filePath = "../RestaurantDL/Database/";
        private string jsonString;
        public Restaurant AddRestaurant(Restaurant rest)
        {
            var restaurants = GetRestaurantInfo();
            restaurants.Add(rest);
            var restaurantString = JsonSerializer.Serialize<List<Restaurant>>(restaurants, new JsonSerializerOptions { WriteIndented = true });
       
        try 
            {
                File.WriteAllText(filePath + "Restaurant.json", restaurantString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rest;
        }
        

        public List<Restaurant> GetRestaurantInfo()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Restaurant.json");
            }
            catch (DirectoryNotFoundException ex)
            { 
               Console.WriteLine("Please check the path, "+ex.Message);
            }
               catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
            {
                return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
            }
            else
            {
                return null;
            }
        }

       
    }
}
