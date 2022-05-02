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
        List<Review> GetAllReviews();
        List<Review> GetAverage();
        List<User> GetUser();
        void AddUser(Restaurant user);
        void AddRestaurant(Restaurant restaurantToAdd);
        void AddReview(Review review);
        

        void AverageRating(int Rating, int Sum);
    }
}
