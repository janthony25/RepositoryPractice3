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
            CustomerEntity = _db.Set<tblCustomer>();
            IssueEntity = _db.Set<tblIssue>();
        }

        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer()
        {
            var customerWithIssue = _db.Set<ViewTblCustomerWithIssue>();
            return customerWithIssue.AsEnumerable();
        }

        public void AddCustomer(tblCustomer entity)
        {
            CustomerEntity.Add(entity);
        }
    }
}
