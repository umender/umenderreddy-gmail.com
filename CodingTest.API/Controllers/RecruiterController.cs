using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.API.Filters.Auth;
using CodingTest.BAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {
        private IRecruiter _recruiter;


        public RecruiterController(IRecruiter recruiter)
        {
            _recruiter = recruiter;

        }
        [AuthReader]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You are authorized User");
        }
    }
}