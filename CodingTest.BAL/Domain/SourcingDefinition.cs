using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.BAL.Domain
{
    public class SourcingDefinition 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SearchCriteria { get; set; }
        public string TargetCompanies { get; set; }
        public int OpenPositions { get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime CloseBy { get; set; }
        public string SourcingStratergy { get; set; }

    }
}
