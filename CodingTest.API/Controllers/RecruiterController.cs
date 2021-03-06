﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.API.Filters;
using CodingTest.API.Filters.Auth;
using CodingTest.BAL;
using CodingTest.BAL.Domain;
using CodingTest.BAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {

        private IUnitOfWork _unitOfWork;

        public RecruiterController(IUnitOfWork unitOf)
        {

            _unitOfWork = unitOf;

        }
        [AuthReader]
        [HttpGet]
        public IActionResult Get()
        {
          var Recruters=  _unitOfWork.RecruiterRepo.GetAll().ToList();
            return Ok(Recruters);
        }
        [AuthContributer]
        [HttpPost]
        public IActionResult Post(Recruiter recruiter)
        {
            if (recruiter == null)
            {
                return Ok("Invalid Recruiter");
            }
            else
            {
                _unitOfWork.RecruiterRepo.Add(recruiter);
                _unitOfWork.Complete();
                return Ok(recruiter);
            }

        }
        [AuthContributer]
        [HttpPut]
        public IActionResult Update(Recruiter recruiter)
        {
            if (recruiter == null)
            {
                return Ok("Invalid Recruiter");
            }
            else
            {
                _unitOfWork.RecruiterRepo.Update(recruiter);
                _unitOfWork.Complete();
                return Ok(recruiter);
            }

        }
        [AuthFullAccess]
        [HttpDelete]
        public IActionResult Delete(Recruiter recruiter)
        {
            if (recruiter == null)
            {
                return Ok("Invalid Recruiter");
            }
            else
            {
                _unitOfWork.RecruiterRepo.Remove(recruiter);
                _unitOfWork.Complete();
                return Ok(recruiter);
            }

        }
    }
}