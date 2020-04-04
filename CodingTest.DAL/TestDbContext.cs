using CodingTest.BAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodingTest.DAL
{
  public  class TestDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CodingTest;Integrated Security=True");
        }
        public virtual DbSet<Recruiter> Recruiter { get; set; }
        public virtual DbSet<SourcingDefinition> SourcingDefinition { get; set; }
        public virtual DbSet<CandiateTracker> CandiateTracker { get; set; }
       

    }
}
