using CodingTest.BAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace CodingTest.BAL.Repositories
{
    public interface ICandiateTracker :IRepository<CandiateTracker>
    {
        CandiateVM GetCandiateTracker();
    }
}
