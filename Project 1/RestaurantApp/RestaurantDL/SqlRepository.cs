using Microsoft.Data.SqlClient;
using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public class SqlRepository : IRepository
    {
        /// <summary>
        /// Creats a path for the sql database using a text file with the connection string.
        /// </summary>
        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //readonly string connectionString;
       // private const string connectionStringFilePath = "C:/Revature/dotnet-training-220328/Daniel-Oszczapinski/Project 1/RestaurantApp/RestaurantDL/connection-string.txt";
       readonly string connectionString;
       
        /// <summary>
        /// Uses Sql connection to read the datbase and place it into a object.
        /// </summary>
        /*public SqlRepository()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }*/
        /// <summary>
        /// Adds Restaurant Info into the database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>rest</returns>
        public Restaurant AddRestaurant(Restaurant rest)
        {
            string commandString = "INSERT INTO Restaurant (Name, City, State, Address, ZipCode) VALUES (@name, @city, @state, @address, @zipcode);";
            using SqlConnection connection = new(connectionString);
            using SqlCommand cmd = new (commandString, connection);
            cmd.Parameters.AddWithValue("@name", rest.Name);
            cmd.Parameters.AddWithValue("@city", rest.City);
            cmd.Parameters.AddWithValue("@state", rest.State);
            cmd.Parameters.AddWithValue("@address", rest.Address);
            cmd.Parameters.AddWithValue("@zipcode", rest.ZipCode);
            connection.Open();
            cmd.ExecuteNonQuery();  

            return rest;
        }
        /// <summary>
        /// Adding review details to the database
        /// </summary>
        /// <param name="reviewToAdd"></param>
        /// <returns>reviewToAdd</returns>
        public Review AddReview(Review reviewToAdd)
        {
            string commandString = "INSERT INTO Review (RestId, Rating, Note) " +
            "VALUES (@id, @rating, @note);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@id", reviewToAdd.RestId);
            command.Parameters.AddWithValue("@rating", reviewToAdd.Rating);
            command.Parameters.AddWithValue("@note", reviewToAdd.Note);
            
            connection.Open();
            command.ExecuteNonQuery();

            return reviewToAdd;
        }
        /// <summary>
        /// Adding user details into the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user</returns>
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
        /// Gets the Restaurant from the database to be called
        /// </summary>
        /// <returns>an list of restaurant information</returns>
        public List<Restaurant> GetRestaurantInfo()
        {
            string commandString = $"SELECT * FROM Restaurant";


            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            var restaurants = new List<Restaurant>();
            foreach (DataRow row in dataSet.Tables[0].Rows) 
            {
                restaurants.Add(new Restaurant
                {
                    RestId = (int)row["RestId"],
                    Name = (string)row["Name"],
                    State = (string)row["State"],
                    City = (string)row["City"],
                    Address = (string)row["Address"],
                    ZipCode = (string)row["ZipCode"]

                }); ;
            }
            return restaurants;
        }
        /// <summary>
        /// Use the Database to get the average from a table grouped by restaurant name
        /// </summary>
        /// <returns>The average of each restaurant </returns>
        public List<AverageRating> GetAverage()
        {
            string commandString = "SELECT  Name,State,City, Address, ZipCode, AVG(Rating) AS Average FROM Review LEFT JOIN Restaurant ON Review.RestId = Restaurant.RestId GROUP BY Name,State, City,Address,ZipCode";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            var average = new List<AverageRating>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                average.Add(new AverageRating
                {
                    Name = (string)row["Name"],
                    State= (string)row["State"],
                    City= (string)row["City"],
                    Address= (string)row["Address"],
                    ZipCode= (string)row["ZipCode"],
                    Average = (double)row["Average"]

                });
            }
            return average;
        }
        /// <summary>
        /// Gets the review information and the average from database 
        /// </summary>
        /// <returns></returns>
        public List<Review> GetReviewInfo()
        {
            string commandString = "SELECT r.* , rt.Name from Review as r JOIN Restaurant as rt on r.RestId = rt.RestId Order by r.ReviewId desc";


            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            var reviews = new List<Review>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                reviews.Add(new Review
                {
                    ReviewId = (int)row["ReviewId"],
                   RestId = (int)row["RestId"],
                    Note = (string)row["Note"],
                    Rating = (double)row["Rating"]
                    
                    
                });
            }
            return reviews;
        }
        /// <summary>
        /// Gets the User Information from database
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsersInfo()
        {
            string commandString = "SELECT * FROM newUser";



            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            var users = new List<User>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                users.Add(new User
                {
                    UserId = (int)row["UserId"],
                    Name = (string)row["Name"],
                    Email = (string)row["Email"],
                    Password = (string)row["Password"]
                });
            }
            return users;
        }
     
        /// <summary>
        /// Gets review information to use for the search option
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
       

        /// <summary>
        /// Finding if there is duplicates 
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsDuplicate(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            string commandString = "SELECT * FROM Restaurants;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            var restaurants = new List<Restaurant>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurants.Add(new Restaurant
                {
                    RestId = (int)row["RestId"],
                    Name = (string)row["Name"],
                    State = (string)row["State"],
                    City = (string)row["City"],
                    Address = (string)row["Address"],
                    ZipCode = (string)row["ZipCode"]

                });
            }
            return restaurants;
        }
    }
}
