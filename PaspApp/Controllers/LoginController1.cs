using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaspApp.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
