using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaspApp.Controllers
{
    public class ErrorController : Controller
    {       
        public IActionResult Error() => View();
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
        public ActionResult BadRequest()
        {
            Response.StatusCode = 400;
            return View();
        }
        public ActionResult InternalServerError()
        {
            Response.StatusCode = 500;
            return View();
        }
        public ActionResult Conflict()
        {
            Response.StatusCode = 409;
            return View();
        }
    }
}
