using CodingTest.BAL.Domain;
using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CodingTest.DAL.Repositories
{
    public class RecruiterRepo : Repository<Recruiter>, IRecruiter
    {
        public RecruiterRepo(TestDbContext context):base(context)
        {
                
        }

        public int EmployeeId { get  ; set  ; }
        public string EmployeeName { get  ; set  ; }
        public string Role { get  ; set  ; }
        public string Operations { get  ; set  ; }
        public decimal BusinessUnit { get  ; set  ; }
    }
}
