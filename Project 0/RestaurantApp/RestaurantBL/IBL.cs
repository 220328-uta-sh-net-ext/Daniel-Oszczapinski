using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
    public interface IBL
    {
        //List<Review> SearchRestaurant(string searchTerm);
        List<Restaurant> GetAllRestaurants();
        List<Review> GetAllReviews();
      
        List<User> GetUser();
      
    }
}
