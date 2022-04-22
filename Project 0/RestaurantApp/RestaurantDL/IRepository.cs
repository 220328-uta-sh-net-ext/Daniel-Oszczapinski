using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public interface IRepository
    {
        /// <summary>
        /// Adds a resturant to the database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant rest);
        /// <summary>
        /// The method returns all restaurants from the database
        /// </summary>
        /// <returns></returns>
        List<Restaurant> GetRestaurantInfo();
        /// <summary>
        /// Adds rating to restuarant
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        //Restaurant AddRestaurantResult(Restaurant result);
        /// <summary>
        /// The method rating average results
        /// </summary>
        /// <returns></returns>
       //List<Restaurant> GetRestaurantResult();
        
    }
}
