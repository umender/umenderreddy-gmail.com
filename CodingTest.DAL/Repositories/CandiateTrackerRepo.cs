using CodingTest.BAL.Domain;
using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DAL.Repositories
{
   public  class CandiateTrackerRepo : Repository<CandiateTracker> , ICandiateTracker 
    {
        public CandiateTrackerRepo(TestDbContext testDbContext):base(testDbContext)
        {

        }

       
        BAL.Domain.CandiateVM ICandiateTracker.GetCandiateTracker()
        {
            throw new NotImplementedException();
        }
    }
}
