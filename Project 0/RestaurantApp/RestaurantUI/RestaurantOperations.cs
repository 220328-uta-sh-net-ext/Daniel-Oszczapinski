using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
namespace RestaurantUI
{
    internal class RestaurantOperations
    {
        static Repository repository = new Repository();

        public static void GetRestaurantInfo()
        {
            var restaurants = repository.GetRestaurantInfo();
            foreach (var rest in restaurants)
            {
                Console.WriteLine(rest.ToString());
            }
        }
       


    }
}
