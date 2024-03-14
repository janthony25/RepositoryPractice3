using Microsoft.EntityFrameworkCore;
using RepositoryPractice3.Data;
using RepositoryPractice3.Models;

namespace RepositoryPractice3.Repository
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _db;
        private DbSet<tblCustomer> CustomerEntity;
        private DbSet<tblIssue> IssueEntity;

        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable
    }
}
