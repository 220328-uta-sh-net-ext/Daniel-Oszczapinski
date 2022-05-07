using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantInfo;
using RestaurantBL;
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
            var restaurants= _operationsBL.SearchAll();
            return Ok(restaurants);
        }
    }
}
