using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public interface IRepository
    {
        /// <summary>
        /// Adds a resturant to the database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant rest);
        /// <summary>
        /// The method returns all restaurants from the database
        /// </summary>
        /// <returns></returns>
        List<Restaurant> GetRestaurantInfo();
        

        Review AddReview(Review reviewToAdd);
       
        List<Review> GetReviewInfo();
        List<Review> SearchRestaurants(string searchTerm);
        bool IsDuplicate(Restaurant restaurant);

       User AddUser(User user);
       List<User> GetUsersInfo();
       List<Review> GetAverage();
    }
}
