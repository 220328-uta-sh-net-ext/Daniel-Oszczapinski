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
        [HttpPost]
        public ActionResult Post([FromBody] Review review)
        {
            if (review == null)
                return BadRequest("Invalid Review");
            _operationsBL.AddReview(review);
            return CreatedAtAction("Get", review);
        }
        [HttpPut]
        public ActionResult Put([FromQuery] Review review, [FromBody] string rating)
        {
            if (rating == null)
                return BadRequest("Need name to modify");
            try
            {

                var reviews = _operationsBL.GetAllReviews();
                var rev = reviews.Find(x => x.Rating.Equals(rating));
                if (rev == null)
                    return NotFound("Review Not Found!");
                rev.Note = review.Note;
                rev.Rating = review.Rating;
                rev.Name = review.Name;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created("Get", review);

        }
        [HttpDelete]
        public ActionResult Delete(double rating)
        {
            if (rating == null)
                return BadRequest("Must have rating to modify");
            var reviews = (_operationsBL.GetAllReviews());
            var rev = reviews.Find(x => x.Rating.Equals(rating));
            if (rev == null)
                return NotFound("Rating not Found!");
            reviews.Remove(rev);
            return Ok($"The Rating {rating} is Deleted");
        }
    }

}
