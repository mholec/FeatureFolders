using System.Collections.Generic;
using Classic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Classic.Controllers
{
    public class CustomersController : Controller
    {
        [HttpGet("")]
        [HttpGet("customers")]
        public IActionResult Index()
        {
            var customers = new List<CustomerViewModel>()
            {
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel()
            };
            
            return View(customers);
        }
        
        [HttpGet("customers/leads")]
        public IActionResult Leads()
        {
            var leads = new List<CustomerViewModel>()
            {
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel(),
                new CustomerViewModel()
            };
            
            return View(leads);
        }
    }
}