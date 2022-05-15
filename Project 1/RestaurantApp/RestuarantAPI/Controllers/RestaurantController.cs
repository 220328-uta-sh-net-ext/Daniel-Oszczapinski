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
        [HttpGet("name")]
        public ActionResult<Restaurant> Get(string name)
        {
            var rest = _operationsBL.SearcheRstaurants(name);
            if (rest.Count<=0)
                return NotFound($"Restaurant {name} is not in the database.");
            return Ok(rest);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
                return BadRequest("Invalid Resturant");
            _operationsBL.AddRestaurant(restaurant);
            return CreatedAtAction("Get", restaurant);
        }
        [HttpPut]
        public ActionResult Put([FromQuery]Restaurant restaurant, [FromBody]string name)
        {
            if (name == null)
                return BadRequest("Need name to modify");
            try
            {

                var restaurants = _operationsBL.GetAllRestaurants();
                var rest = restaurants.Find(x => x.Name.Contains(name));
                if (rest == null)
                    return NotFound("Restaurant Not Found!");
                rest.Name = restaurant.Name;
                rest.State = restaurant.State;
                rest.Address = restaurant.Address;
                rest.City = restaurant.City;
                rest.ZipCode = restaurant.ZipCode;
            
                    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
            return Created("Get", restaurant);

        }
        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Must have name to modify");
            var restaurants = (_operationsBL.GetAllRestaurants());
            var rest = restaurants.Find(x => x.Name.Contains(name));
            if (rest == null)
                return NotFound("Restaurant Name not Found!");
            restaurants.Remove(rest);
            return Ok($"The Restaurants {name} is Deleted");
        }
       
    }
}
