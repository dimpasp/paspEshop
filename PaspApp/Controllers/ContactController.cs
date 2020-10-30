using Microsoft.AspNetCore.Mvc;
using PaspCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult RealtyNewsLetterSave(string fullName, string email, string regions)
        {
            if (string.IsNullOrEmpty(email)) return Json("Error");

            //in same way query to base,include newsletterservices
            return Json(new { success = true, message = "You just subscribed" });
        }

    }
}
