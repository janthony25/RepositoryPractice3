using Microsoft.AspNetCore.Mvc;
using RepositoryPractice3.Repository.Irepository;

namespace RepositoryPractice3.Controllers
{
    public class CustomerListController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerListController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            ViewBag.CustomerListWithIssue = _customerRepository.GetCustomer();
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.AddCustomer = 
            return View();
        }
    }
}
