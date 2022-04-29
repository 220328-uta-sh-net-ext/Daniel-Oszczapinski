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
            string commandString = "INSERT INTO Restaurant (Name, Address, Phone) VALUES (@name, @address, @phone);";
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new (commandString, connection);
            cmd.Parameters.AddWithValue("@name", rest.Name);
            cmd.Parameters.AddWithValue("@address", rest.Address);
            cmd.Parameters.AddWithValue("@phone", rest.Phone);
            connection.Open();
            cmd.ExecuteNonQuery();  

            return rest;
        }

        public Review AddReview(int restaurantId, Review reviewToAdd)
        {
            throw new NotImplementedException();
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
                    Address = reader.GetString(2),
                    Phone = reader.GetString(3)
                });
            }
            return restaurants;
        }

        public List<Review> GetReviewInfo()
        {
            throw new NotImplementedException();
        }

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
