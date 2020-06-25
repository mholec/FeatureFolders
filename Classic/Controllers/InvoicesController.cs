using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Classic.Models;

namespace Classic.Controllers
{
    public class InvoicesController : Controller
    {
        [HttpGet("invoices")]
        public IActionResult Index()
        {
            var invoices = new List<InvoiceViewModel>()
            {
                new InvoiceViewModel(),
                new InvoiceViewModel(),
                new InvoiceViewModel(),
                new InvoiceViewModel(),
                new InvoiceViewModel(),
                new InvoiceViewModel()
            };
            
            return View(invoices);
        }
        
        [HttpGet("invoices/{id:int}")]
        public IActionResult Detail(int id)
        {
            var invoice = new InvoiceViewModel();
            
            return View(invoice);
        }
    }
}
