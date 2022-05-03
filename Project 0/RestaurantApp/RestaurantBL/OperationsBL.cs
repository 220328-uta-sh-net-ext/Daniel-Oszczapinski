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
        /// Calls the Sql repoistory and sets in into an object
        /// </summary>
        static IRepository repository = new SqlRepository();
    
      
        /// <summary>
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the Restaurant Information</returns>
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
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the Review Information</returns>
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
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the User Information</returns>
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
       
    }
}
