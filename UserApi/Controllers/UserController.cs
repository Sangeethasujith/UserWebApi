using Data;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //public IUsers users=new UserRepository();
        private IUsers _users;
        public UserController(IUsers users)
        {
            _users = users;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return _users.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            return _users.GetUser(id);
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
            _users.Add(user);
            return Ok(user);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, User user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
            User updateUser = _users.GetUser(id);
            if(updateUser == null)
            {
                return NotFound("User is not found");
            }
            _users.Update(updateUser,user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = _users.GetUser(id);
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
            _users.Delete(user);
            return Ok(user);
        }


    }
}
