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

       

        public List<Restaurant> GetRestaurantInfo()
        {
            string commandString = "SELECT * FROM Restaurant";

           
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

        public List<Review> GetReviewInfo()
        {
            string commandString = "SELECT * ,(SELECT AVG(RATING) FROM Review GROUP BY Name) FROM Review";
           

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
                    Rating = reader.GetInt32(4),
                    Average = reader.GetInt32(5)
                });
            }
            return reviews;
        }

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
        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
