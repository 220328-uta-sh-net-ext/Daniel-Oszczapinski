using RestaurantDL;
using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
    public class OperationsBL : IBL
    {
        static Repository repository = new Repository();
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddReview(int reviewId, Review reviewToAdd)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            
                var restaurants = repository.GetRestaurantInfo();
                foreach (var rest in restaurants)
                {
                    Console.WriteLine(rest.ToString());
                }
                return restaurants;
            
        }

        public List<Restaurant> SearchRestaurant(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
