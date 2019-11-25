using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAgoraVai.Models;
using NewsAgoraVai.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsAgoraVai.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        // GET: api/values
        [HttpGet]
        public List<User> Get()
        {
            return UserService.ListUsers();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<bool> Post([FromBody]User user)
        {
            if (user != null)
            {
                UserService.AddUser(user);
                return true;
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost("login")]
        public ActionResult<bool> Login([FromBody]User user)
        {
            if (user != null)
            {
                return RedirectToAction("New", "News");


            }
            else
            {
                return false;
            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
