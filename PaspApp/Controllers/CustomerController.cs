using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaspCore.Data;
using PaspCore.Model;

namespace PaspApp.Controllers
{
    public class CustomerController : Controller
    {
        private PaspDbContext _context;
        public CustomerController()
        {
            _context = new PaspDbContext();
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerForm
            {
                Customer = customer,             
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerForm
                {
                    Customer = customer                   
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerDb.Firstname = customer.Firstname;
                customerDb.Lastname = customer.Lastname;
                customerDb.Phone = customer.Phone;
                customerDb.WholesaleCustomer = customer.WholesaleCustomer;
                customerDb.Email = customer.Email;
                customerDb.VatNumber = customer.VatNumber;
                customerDb.Password = customer.Password;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

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
