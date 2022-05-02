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
        /// <summary>
        /// 
        /// </summary>
        static IRepository repository = new SqlRepository();
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reviewToAdd"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddReview(Review reviewToAdd)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddUser(Restaurant user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate average rating, need to connect to database to get the array of ratingss
        /// </summary>
        /// <param name="Rating"></param>
        /// <param name="Sum"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AverageRating(int Rating, int Sum)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Restaurant> GetAllRestaurants()
        {
            
                var restaurants = repository.GetRestaurantInfo();
                foreach (var rest in restaurants)
                {
                    Console.WriteLine(rest.ToString());
                    Console.WriteLine("*******************");
                }
                return restaurants;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Review> GetAllReviews()
        {
            List<Review> reviews = repository.GetReviewInfo();
            List<Review> average = repository.GetAverage();
           
            //var ReviewsAndAverage = reviews.Zip(average);
            foreach (var view in reviews)
            {
                Console.WriteLine(view.ToString());
                Console.WriteLine("*******************");
               
            
            }
            return reviews;
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Review> GetAverage()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetUser()
        {
            var users = repository.GetUsersInfo();
            foreach(var user in users) 
            { 
                Console.WriteLine(user.ToString());
                Console.WriteLine("*******************");
            }
            return users;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /*public List<Review> SearchRestaurant(string searchTerm)
        {
            var restaurants = repository.GetReviewInfo();
            var filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(searchTerm)).ToList();

            return filteredRestaurants;

        }*/
    }
}
