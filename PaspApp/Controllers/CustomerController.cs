using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaspApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
    }
}
