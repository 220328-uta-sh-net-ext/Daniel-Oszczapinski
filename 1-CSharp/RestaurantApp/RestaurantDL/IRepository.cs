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
        /// 
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant rest);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Restaurant> GetRestaurantInfo();
    }
}
