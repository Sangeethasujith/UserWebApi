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
    }
}
