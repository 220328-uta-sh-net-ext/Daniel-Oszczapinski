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
        /// <summary>
        /// Gets all the reviews from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Review>> GetReview()
        {
            var reviews = _operationsBL.GetAllReviews();
            return Ok(reviews);
        }
        /// <summary>
        /// Adds review to database
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Review review)
        {
            if (review == null)
                return BadRequest("Invalid Review");
            _operationsBL.AddReview(review);
            return CreatedAtAction("Get", review);
        }
        /// <summary>
        /// Should edit review by id
        /// </summary>
        /// <param name="review"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpPut]
        //public ActionResult Put([FromQuery] Review review, [FromBody] string id)
        //{
        //    if (id == null)
        //        return BadRequest("Need name to modify");
        //    try
        //    {

        //        var reviews = _operationsBL.GetAllReviews();
        //        var rev = reviews.Find(x => x.ReviewId.Equals(id));
        //        if (rev == null)
        //            return NotFound($"Id {id} Not Found!");
        //        rev.Note = review.Note;
        //        rev.Rating = review.Rating;
        //        rev.RestId = review.RestId;

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //    return Created("Get", review);

        //}
        /// <summary>
        /// Should delete by id
        /// </summary>
        /// <param name="reviewid"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult Delete(int reviewid, int restid)
        {


            try
            {
                if (_operationsBL.RemoveReview(reviewid,restid) == true)
                    return Ok($"Restaurant review Deleted!");
                else
                    return BadRequest($"Restaurant review does not exist");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
