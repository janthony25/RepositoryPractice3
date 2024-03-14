using RepositoryPractice3.Models;

namespace RepositoryPractice3.Repository.Irepository
{
    public interface ICustomerRepository
    {
        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer();
    }
}
