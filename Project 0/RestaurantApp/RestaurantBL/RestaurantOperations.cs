using RestaurantDL;
namespace RestaurantBL
{
    //calculate the rating average, search restuarant and user, adding a user
    public abstract  class RestaurantOperations
    {
        //add User
        public abstract void Add(RestaurantDL.Users users);
        //Find user
        public abstract RestaurantDL.Users SearchUsers(string id);
        //Add review
        public abstract void Review(RestaurantDL.Users users);
        //calculate average rating 
        public virtual decimal Average(decimal reviewNum)
        {
            return 0;
        }

    }
    public class RestaurantImplementation : IRestaurantOperations
    {
        public  void Add(RestaurantDL.Users users)
        {
            throw new NotImplementedException();
        }
        public RestaurantDL.Users SearchUsers(string id)   
        {
            throw new NotImplementedException();
        }
        public  void Review(RestaurantDL.Users users)
        {
            throw new NotImplementedException();
        }
        
    }
}