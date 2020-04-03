using CodingTest.BAL.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DAL
{
  public  class TestDbContext :DbContext
    {
        public TestDbContext() 
        {
            // this.Database.Connection.ConnectionString = "Data Source=.;Initial Catalog=CodingTest;Integrated Security=True;Pooling=False";
           
        }
        public virtual DbSet<Recruiter> Recruiters { get; set; }
        public virtual DbSet<SourcingDefinition> SourcingDefinitions { get; set; }
        public virtual DbSet<CandiateTracker> CandiateTrackers { get; set; }
       

    }
}
