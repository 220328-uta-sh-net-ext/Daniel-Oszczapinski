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
        static IRepository repository = new SqlRepository();
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddReview(int reviewId, Review reviewToAdd)
        {
            throw new NotImplementedException();
        }

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

        public List<Restaurant> GetUser()
        {
            /*var users = repository.GetRestaurantInfo;
            foreach(var user in users) 
            { 
                Console.WriteLine(users.ToString());
               
            }
            return users;*/
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurant(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
