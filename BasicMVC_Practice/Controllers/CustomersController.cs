using Microsoft.AspNetCore.Mvc;
using BasicMVC_Practice.Models;

namespace BasicMVC_Practice.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                WelcomeMessage = "Welcome to our customer portal!"
            };
            return View(viewModel);
        }
    }
}
