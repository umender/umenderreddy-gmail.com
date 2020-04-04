using CodingTest.BAL;
using CodingTest.BAL.Repositories;
using CodingTest.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
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

        public UnitofWork()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
          
            _context = new TestDbContext();
            RecruiterRepo  = new RecruiterRepo(_context);
            CandiateTrackerRepo = new CandiateTrackerRepo(_context);
            SourcingDefinitionRepo = new SourcingDefinitionRepo(_context);
        
        }
        public int Complete()
        {
         return   _context.SaveChanges();
        }

        public void Dispose()
        {
             _context.Dispose();
        }
    }
}
