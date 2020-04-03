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
    }
}
