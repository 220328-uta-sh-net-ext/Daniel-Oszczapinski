using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBL;
using RestaurantInfo;

namespace RestuarantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IBL _operationsBL;

        public UserController(IBL _operationsBL)
        {
            this._operationsBL = _operationsBL;
        }

        [HttpGet]
       public ActionResult<List<User>> GetUser()
       {
           var users = _operationsBL.GetUser();
           return Ok(users);
       }
    }
}
