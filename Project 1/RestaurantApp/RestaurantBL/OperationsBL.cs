using RestaurantDL;
using RestaurantInfo;
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
       readonly IRepository repo;
        public OperationsBL(IRepository repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// Calls the Sql repoistory and sets in into an object
        /// </summary>
       // static IRepository repository = new SqlRepository();


        /// <summary>
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the Restaurant Information</returns>
        public List<Restaurant> GetAllRestaurants()
        {
           
            return repo.GetRestaurantInfo();
            
        }
        public List<Restaurant> SearchAll()
        {
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the Review Information</returns>
        public List<Review> GetAllReviews()
        {
        
            
            return repo.GetReviewInfo();




        }

        /// <summary>
        /// Gets list from the database and uses foreach to print out the info
        /// </summary>
        /// <returns>Prints out a String of the User Information</returns>
        public List<User> GetUser()
        {

            return repo.GetUsersInfo();


        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            return repo.AddRestaurant(restaurant);
        }

        public Review AddReview(Review review)
        {
            return repo.AddReview(review);
        }

        public User AddUser(User user)
        {
            return repo.AddUser(user);
        }

        public List<Restaurant> SearcheRstaurants(string name)
        {
            List<Restaurant>? restaurants = repo.GetRestaurantInfo();
            var filteredRestaurant = restaurants.Where(x => x.Name.Contains(name)).ToList();
            return filteredRestaurant;
        }

        public List<AverageRating> GetAverageRating()
        {
            return repo.GetAverage();
        }

        public List<User> SearchUser(string name)
        {
            List<User>? users = repo.GetUsersInfo();
            var filteredUser = users.Where(x => x.Name.Contains(name)).ToList();
            return filteredUser;
        }
    }
}
