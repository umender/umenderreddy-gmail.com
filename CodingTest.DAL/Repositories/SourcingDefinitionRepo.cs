using CodingTest.BAL.Domain;
using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DAL.Repositories
{
   public class SourcingDefinitionRepo :Repository<SourcingDefinition>, ISourcingDefinition
    {
        public SourcingDefinitionRepo(TestDbContext context):base(context)
        {

        }
    }
}
