using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa.NetCore;
using MVCTraining.Models;

namespace MVCTraining.Controllers
{
    public class CustomerController : Controller
    {

        private List<Customer> _customers;

        public CustomerController()
        {
            var imagePath = "banner1.svg";

            _customers = new List<Customer>()

            { new Customer { CustomerId = 1, FirstName = "Jali",
                LastName = "Lili", ProfileImage = imagePath },
            new Customer { CustomerId = 2, FirstName = "JUJI",
                LastName = "Mimi", ProfileImage = imagePath }
            };

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Print() => new ActionAsPdf("Index", _customers);

        public IActionResult PrintView() => new ViewAsPdf("Index", _customers);
    }
}