using Microsoft.Data.SqlClient;
using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public class SqlRepository : IRepository
    {
        
        private const string connectionStringFilePath = "C:/Revature/dotnet-training-220328/Daniel-Oszczapinski/Project 0/RestaurantApp/RestaurantDL/connection-string.txt";
        private readonly string connectionString;
      
        /// <summary>
        /// 
        /// </summary>
        public SqlRepository()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }
        public Restaurant AddRestaurant(Restaurant rest)
        {
            string commandString = "INSERT INTO Restaurant (Name, City, State) VALUES (@name, @city, @state);";
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new (commandString, connection);
            cmd.Parameters.AddWithValue("@name", rest.Name);
            cmd.Parameters.AddWithValue("@city", rest.City);
            cmd.Parameters.AddWithValue("@state", rest.State);
            connection.Open();
            cmd.ExecuteNonQuery();  

            return rest;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reviewToAdd"></param>
        /// <returns></returns>
        public Review AddReview(Review reviewToAdd)
        {
            string commandString = "INSERT INTO Review (Name, UserName, Rating, Note) " +
            "VALUES (@name, @username, @rating, @note);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", reviewToAdd.Name);
            command.Parameters.AddWithValue("@username", reviewToAdd.UserName);
            command.Parameters.AddWithValue("@rating", reviewToAdd.Rating);
            command.Parameters.AddWithValue("@note", reviewToAdd.Note);
            connection.Open();
            command.ExecuteNonQuery();

            return reviewToAdd;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User AddUser(User user)
        {
            string commandString = "INSERT INTO NewUser (Name, Email, Password) VALUES (@name, @email, @password);";
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new(commandString, connection);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            connection.Open();
            cmd.ExecuteNonQuery();

            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Restaurant> GetRestaurantInfo()
        {
            string commandString = $"SELECT * FROM Restaurant";

           
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            var restaurants = new List<Restaurant>();

            while (reader.Read()) 
            {
                restaurants.Add(new Restaurant
                {
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State= reader.GetString(3)
                });
            }
            return restaurants;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Review> GetAverage()
        {
            string commandString =  "SELECT AVG(Rating) as Average From Review GROUP BY Name";
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            var average = new List<Review>();

            while (reader.Read())
            {
                average.Add(new Review
                {
                    Average = reader.GetDouble(0),
                  

                });
            }
            return average;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Review> GetReviewInfo()
        {
            string commandString = "SELECT* FROM(SELECT* FROM Review) AS t1 INNER JOIN(SELECT Name, AVG(Rating) as Average From Review GROUP BY Name) AS t2 ON t1.Name = t2.Name ORDER BY ReviewId ASC";
           

            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            var reviews = new List<Review>();

            while (reader.Read())
            {
                reviews.Add(new Review
                {
                    Name = reader.GetString(1),
                    UserName = reader.GetString(2),
                    Note = reader.GetString(3),
                    Rating = reader.GetDouble(4),
                    Average = reader.GetDouble(6),
                });
            }
            return reviews;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsersInfo()
        {
            string commandString = "SELECT * FROM newUser";


            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new SqlCommand(commandString, connection);
            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            var users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Name = reader.GetString(1),
                    Email = reader.GetString(2),
                    Password = reader.GetString(3)
                });
            }
            return users;
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="restaurant"></param>
       /// <returns></returns>
       /// <exception cref="NotImplementedException"></exception>
        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Review> SearchRestaurants(string searchTerm)
        {
            return GetReviewInfo();
        }
        /*public List<Review> GetAverage()
       {

           string commandString = "SELECT Name, AVG(RATING) FROM Review GROUP BY Name";


           using SqlConnection connection = new(connectionString);
           using SqlCommand cmd = new SqlCommand(commandString, connection);
           connection.Open();
           using SqlDataReader reader = cmd.ExecuteReader();

           var reviews = new List<Review>();

           while (reader.Read())
           {
               reviews.Add(new Review
               {
                   Rating = reader.GetInt32(4)
               });
           }
           return reviews;
       }*/
    }
}
