using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private DatabaseInterface _data;
        public UserController (DatabaseInterface data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult <IEnumerable<User>> GetUsers()
        {
            return Ok(_data.GetUsers());
        }

        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(int id)
        {
            return Ok(_data.GetUserById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            _data.AddUser(user);
            return Ok((new {message="a new user created"}));
        }



        //[HttpDelete]
        //public ActionResult Delete([FromBody] User user,int id)
        //{
        //    _data.DeleteUser(user,id);
        //    return Ok((user));
        //}

    }
}
