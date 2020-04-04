using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodingTest.BAL.Domain
{
    public class CandiateTracker 
    {
        public string CandiateName { get; set; }
        [Key]
        public int CandidateId { get; set; }
        public string CandiateExpertise { get; set; }
        public string SourcingDefinition { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public virtual Recruiter Recruiter  { get; set; }
        public string Stratergy { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime ContactedOn { get; set; }
        public DateTime InterviewedOn { get; set; }
        public DateTime JoiningOrderSenton { get; set; }
        public string Remarks { get; set; }
    }
}
