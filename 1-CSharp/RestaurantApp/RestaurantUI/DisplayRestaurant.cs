using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
namespace RestaurantUI
{
    internal class DisplayRestaurant
    {
        static Repository repository = new Repository();

        public static void GetRestaurantInfo()
        {
            repository.GetRestaurantInfo();
        }
    }
}
