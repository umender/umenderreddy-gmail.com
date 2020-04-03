using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.BAL.Domain;
using CodingTest.BAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CodingTest.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser  _user;


        public UserController(IUser user)
        {
            _user = user;
        }
      

        [AllowAnonymous]
        //[HttpPost("authenticate")]
        [HttpPost]
        public IActionResult Post(string uname,string pwd)
        {
          
            var user = _user.Authenticate(uname, pwd);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello");
        }
    }
}