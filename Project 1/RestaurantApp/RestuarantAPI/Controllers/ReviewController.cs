using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RestaurantBL;
using RestaurantInfo;
using RestuarantAPI.Repository;

namespace RestuarantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

       
        private IBL _operationsBL;
        
        public ReviewController(IBL _operationsBL)
        {
            this._operationsBL = _operationsBL;
        }
       
        [HttpGet]
        public ActionResult<List<Review>> GetReview()
        {
            var reviews = _operationsBL.GetAllReviews();
            return Ok(reviews);
        }
    }
}
