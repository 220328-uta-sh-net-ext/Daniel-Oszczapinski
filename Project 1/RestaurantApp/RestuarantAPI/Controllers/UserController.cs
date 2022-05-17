using Microsoft.AspNetCore.Authorization;
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
        /// <summary>
        /// Get all users in database
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
       public ActionResult<List<User>> GetUser()
       {
           var users = _operationsBL.GetUser();
           return Ok(users);

       }
        [Authorize]
        [HttpGet("name")]
        
        public ActionResult<User> Get(string name)
        {
            var users = _operationsBL.SearchUser(name);
            if (users.Count <= 0)
                return NotFound($"Restaurant {name} is not in the database.");
            return Ok(users);
           
        }
        /// <summary>
        /// Add user to database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Invalid User");
            _operationsBL.AddUser(user);
            return CreatedAtAction("Get", user);
        }
        /// <summary>
        /// Edit user by name
        /// </summary>
        /// <param name="user"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        //[HttpPut]
        //public ActionResult Put([FromQuery] User user, [FromBody] string name)
        //{
        //    if (name == null)
        //        return BadRequest("Need name to modify");
        //    try
        //    {

        //        var users = _operationsBL.GetUser();
        //        var us = users.Find(x => x.Name.Contains(name));
        //        if (us == null)
        //            return NotFound("Restaurant Not Found!");
        //        us.Name = user.Name;
        //        us.Email = user.Email;
        //        us.Password = user.Password;

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //    return Created("Get", user);

        //}
        /// <summary>
        /// Delete user by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult Delete(string name)
        {

            try
            {

                if (_operationsBL.RemoveUser(name) == true)
                    return Ok($"User {name} Deleted!");
                else
                    return BadRequest($"User {name} does not exist");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    
}
