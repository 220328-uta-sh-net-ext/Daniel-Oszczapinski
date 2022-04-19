using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
namespace RestaurantBL
{
    internal interface IRestaurantOperations
    {
        void Add(RestaurantDL.Users users);
        RestaurantDL.Users SearchUsers(string id);
         
        
    }
}
