using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantInfo;
using RestaurantBL;
using Microsoft.Extensions.Caching.Memory;
using RestuarantAPI.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace RestuarantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
       
        private IBL _operationsBL;
        private IMemoryCache memoryCache;
        public RestaurantController(IBL _operationsBL, IMemoryCache memoryCache)
        {
            this._operationsBL = _operationsBL;
            this.memoryCache = memoryCache;
        }
        /// <summary>
        /// Get Method, Gets all restuarants in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Restaurant>> Get()
        {
            var restaurants= _operationsBL.GetAllRestaurants();
            return Ok(restaurants);
        }
        /// <summary>
        /// Search Restaurant by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("name")]
        public ActionResult<Restaurant> Get(string name)
        {
            var rest = _operationsBL.SearcheRstaurants(name);
            if (rest.Count<=0)
                return NotFound($"Restaurant {name} is not in the database.");
            return Ok(rest);
        }
        /// <summary>
        /// Adds a Restaurant to the database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        
        public ActionResult Post([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
                return BadRequest("Invalid Resturant");
            _operationsBL.AddRestaurant(restaurant);
            return CreatedAtAction("Get", restaurant);
        }
        /// <summary>
        /// Should edit restaurant by name.
        /// </summary>
        /// <param name="restaurant"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        //[Authorize]
        //[HttpPut]
        
        //public ActionResult Put([FromBody]Restaurant restaurant, [FromQuery]string name)
        //{
        //    if (name == null)
        //        return BadRequest("Need name to modify");
        //    try
        //    {

        //        var restaurants = _operationsBL.GetAllRestaurants();
        //        var rest = restaurants.Find(x => x.Name.Contains(name));
        //        if (rest == null)
        //            return NotFound("Restaurant Not Found!");
        //        rest.Name = restaurant.Name;
        //        rest.State = restaurant.State;
        //        rest.Address = restaurant.Address;
        //        rest.City = restaurant.City;
        //        rest.ZipCode = restaurant.ZipCode;
            
                    
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
          
        //    return Created("Get", restaurant);

        //}
        /// <summary>
        /// Should delete restaurant by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //[Authorize]
        //[HttpDelete]
        
        //public ActionResult Delete(string name)
        //{
        //    if (name == null)
        //        return BadRequest("Must have name to modify");

        //    try
        //    {
        //        var restaurants = _operationsBL.GetAllRestaurants();
        //        var rest = restaurants.Find(x => x.Name.Contains(name));
        //        if (rest == null)
        //            return NotFound("Restaurant Name not Found!");
        //        restaurants.Remove(rest);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
               
            
             
        //    return Ok($"The Restaurants {name} is Deleted");
        //}
       
    }
}
