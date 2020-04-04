using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace CodingTest.BAL.Domain
{
    public class Recruiter 
    {
        [Key]       
        public int EmployeeId { get ; set ; }
        public string EmployeeName { get ; set ; }
        public string Role { get ; set ; }
        public string Operations { get ; set ; }
        public decimal BusinessUnit { get ; set ; }

       
    }
}
