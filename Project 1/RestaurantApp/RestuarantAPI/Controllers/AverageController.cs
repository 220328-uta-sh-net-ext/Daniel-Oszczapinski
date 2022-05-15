using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBL;
using RestaurantInfo;

namespace RestuarantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AverageController : ControllerBase
    {
        private IBL _operationsBL;

        public AverageController(IBL _operationsBL)
        {
            this._operationsBL = _operationsBL;
        }
        [HttpGet]
        public ActionResult<List<AverageRating>> Get()
        {
            var average = _operationsBL.GetAverageRating();
            return Ok(average);
        }
    }
}
