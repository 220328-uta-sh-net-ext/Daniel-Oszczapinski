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
        [HttpGet("name")]
        public ActionResult<User> Get(string name)
        {
            var users = _operationsBL.SearchUser(name);
            if (users.Count <= 0)
                return NotFound($"Restaurant {name} is not in the database.");
            return Ok(users);
        }
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Invalid User");
            _operationsBL.AddUser(user);
            return CreatedAtAction("Get", user);
        }
        [HttpPut]
        public ActionResult Put([FromQuery] User user, [FromBody] string name)
        {
            if (name == null)
                return BadRequest("Need name to modify");
            try
            {

                var users = _operationsBL.GetUser();
                var us = users.Find(x => x.Name.Contains(name));
                if (us == null)
                    return NotFound("Restaurant Not Found!");
                us.Name = user.Name;
                us.Email = user.Email;
                us.Password = user.Password;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created("Get", user);

        }
        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Must have name to modify");
            var users = (_operationsBL.GetUser());
            var us = users.Find(x => x.Name.Contains(name));
            if (us == null)
                return NotFound("User Name not Found!");
            users.Remove(us);
            return Ok($"The User {name} is Deleted");
        }
    }
}
