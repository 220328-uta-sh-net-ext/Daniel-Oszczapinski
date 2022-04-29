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
        List<Restaurant> SearchRestaurant(string searchString);
        List<Restaurant> GetAllRestaurants();

        List<Restaurant> GetUser();
        void AddUser(Restaurant user);
        void AddRestaurant(Restaurant restaurantToAdd);
        void AddReview(int reviewId, Review review);

        void AverageRating(int Rating, int Sum);
    }
}
