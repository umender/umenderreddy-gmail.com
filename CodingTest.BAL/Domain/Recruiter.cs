using CodingTest.BAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CodingTest.BAL.Domain
{
   public class Recruiter : IRecruiter
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Role { get; set; }
        public string Operations { get; set; }
        public decimal BusinessUnit { get; set; }

        public void Add(Recruiter entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Recruiter> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recruiter> Find(Expression<Func<Recruiter, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Recruiter Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recruiter> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Recruiter entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Recruiter> entities)
        {
            throw new NotImplementedException();
        }

        public Recruiter SingleOrDefault(Expression<Func<Recruiter, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Recruiter entity)
        {
            throw new NotImplementedException();
        }
    }
}
