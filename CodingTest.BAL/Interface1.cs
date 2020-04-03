using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.BAL
{
    public interface IUnitOfWork : IDisposable
    {
        public IRecruiter RecruiterRepo  { get; set; }
        public ICandiateTracker CandiateTrackerRepo  { get; set; }
        public ISourcingDefinition SourcingDefinitionRepo  { get; set; }
        int Complete();
    }
}
