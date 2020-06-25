using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Enhanced.Features.Invoices
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
