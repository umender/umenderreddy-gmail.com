using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.API.Filters.Auth;
using CodingTest.BAL;
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

        private IUnitOfWork _unitOfWork;
       
        public RecruiterController(IRecruiter recruiter,IUnitOfWork unitOf)
        {
            _recruiter = recruiter;
            _unitOfWork = unitOf;

        }
        [AuthReader]
        [HttpGet]
        public IActionResult Get()
        {
            _unitOfWork.RecruiterRepo.GetAll();
            return Ok("You are authorized User");
        }
    }
}