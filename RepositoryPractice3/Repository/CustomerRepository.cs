using Microsoft.EntityFrameworkCore;
using RepositoryPractice3.Data;
using RepositoryPractice3.Models;
using RepositoryPractice3.Repository.Irepository;

namespace RepositoryPractice3.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db;
        private DbSet<tblCustomer> CustomerEntity;
        private DbSet<tblIssue> IssueEntity;

        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<VewTblCustomerWithIssue> GetCustomer()
        {
            var customerWithIssue = _db.Set<VewTblCustomerWithIssue>();
            return customerWithIssue.AsEnumerable();
        }
    }
}
