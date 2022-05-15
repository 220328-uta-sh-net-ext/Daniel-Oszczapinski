using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantInfo;
using RestaurantBL;
using Microsoft.Extensions.Caching.Memory;
using RestuarantAPI.Repository;

namespace RestuarantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
       
        private IBL _operationsBL;
        
        public RestaurantController(IBL _operationsBL)
        {
            this._operationsBL = _operationsBL;
        }
        [HttpGet]
        public ActionResult<List<Restaurant>> Get()
        {
            var restaurants= _operationsBL.GetAllRestaurants();
            return Ok(restaurants);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
                return BadRequest("Invalid Resturant");
            _operationsBL.AddRestaurant(restaurant);
            return CreatedAtAction("Get", restaurant);
        }
     

       
    }
}
