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
    [Route("[controller]")]
    [ApiController]
    public class SourcingDefinitionController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public SourcingDefinitionController(IUnitOfWork unitOf)
        {
            _unitOfWork = unitOf;
        }
        [AuthReader]
        [HttpGet]
        public IActionResult Get()
        {
            var sourcings = _unitOfWork.SourcingDefinitionRepo.GetAll().ToList();
            return Ok(sourcings);
        }
        [AuthContributer]
        [HttpPost]
        public IActionResult Post(SourcingDefinition sourcing)
        {
            if (sourcing == null)
            {
                return Ok("Invalid sourcing");
            }
            else
            {
                _unitOfWork.SourcingDefinitionRepo.Add(sourcing);
                _unitOfWork.Complete();
                return Ok(sourcing);
            }

        }
        [AuthContributer]
        [HttpPost]
        public IActionResult Update(SourcingDefinition sourcing)
        {
            if (sourcing == null)
            {
                return Ok("Invalid sourcing");
            }
            else
            {
                _unitOfWork.SourcingDefinitionRepo.Update(sourcing);
                _unitOfWork.Complete();
                return Ok(sourcing);
            }

        }
        [AuthFullAccess]
        [HttpPost]
        public IActionResult Delete(SourcingDefinition sourcing)
        {
            if (sourcing == null)
            {
                return Ok("Invalid sourcing");
            }
            else
            {
                _unitOfWork.SourcingDefinitionRepo.Remove(sourcing);
                _unitOfWork.Complete();
                return Ok(sourcing);
            }

        }

    }
}