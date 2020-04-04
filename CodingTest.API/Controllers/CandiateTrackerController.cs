using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class CandiateTrackerController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public CandiateTrackerController(IUnitOfWork unitOf)
        {
            _unitOfWork = unitOf;
        }
        [AuthReader]
        [HttpGet]
        public IActionResult Get()
        {
            var candiateTrackers = _unitOfWork.CandiateTrackerRepo.GetAll().ToList();
            return Ok(candiateTrackers);
        }
        [AuthContributer]
        [HttpPost]
        public IActionResult Post(CandiateTracker candiateTrackers)
        {
            if (candiateTrackers == null)
            {
                return Ok("Invalid CandiateTracker");
            }
            else
            {
                _unitOfWork.CandiateTrackerRepo.Add(candiateTrackers);
                _unitOfWork.Complete();
                return Ok(candiateTrackers);
            }

        }
        [AuthContributer]
        [HttpPost]
        public IActionResult Update(CandiateTracker candiateTrackers)
        {
            if (candiateTrackers == null)
            {
                return Ok("Invalid CandiateTracker");
            }
            else
            {
                _unitOfWork.CandiateTrackerRepo.Update(candiateTrackers);
                _unitOfWork.Complete();
                return Ok(candiateTrackers);
            }

        }
        [AuthFullAccess]
        [HttpPost]
        public IActionResult Delete(CandiateTracker candiateTrackers)

        {
            if (candiateTrackers == null)
            {
                return Ok("Invalid CandiateTracker");
            }
            else
            {
                _unitOfWork.CandiateTrackerRepo.Remove(candiateTrackers);
                _unitOfWork.Complete();
                return Ok(candiateTrackers);
            }

        }
    }
}