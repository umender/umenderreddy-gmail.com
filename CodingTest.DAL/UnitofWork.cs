using CodingTest.BAL;
using CodingTest.BAL.Repositories;
using CodingTest.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DAL
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly TestDbContext _context;
        public IRecruiter RecruiterRepo   { get ; set ; }
        public ICandiateTracker CandiateTrackerRepo { get ; set ; }
        public ISourcingDefinition SourcingDefinitionRepo { get ; set ; }

        public UnitofWork(TestDbContext context )
        {
            _context = context;
            RecruiterRepo  = new RecruiterRepo(context);
            CandiateTrackerRepo = new CandiateTrackerRepo(context);
            SourcingDefinitionRepo = new SourcingDefinitionRepo(context);
        
        }
        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
