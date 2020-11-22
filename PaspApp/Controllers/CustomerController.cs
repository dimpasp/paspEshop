using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        /// <summary>
        /// 
        /// </summary>
        public CustomerController()
        {
            _context = new PaspDbContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult SendMail()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add()
        {
            return View();
        }
        // <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.Id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        //This must be hidden.Accessable only for owner of project 
        public IQueryable<Customer> SearchCustomer(SearchCustomer options)
        {
            var _customer = _context
                .Set<Customer>()
                .AsQueryable();

            if (options == null)
            {
                return null;
            }

            if (!string.IsNullOrWhiteSpace(options.FirstName))
            {
                _customer = _customer.Where(p =>
                    p.Firstname.Contains(options.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(options.LastName))
            {
                _customer = _customer.Where(p =>
                    p.Lastname == options.LastName);
            }
            if (options.CustomerId > 0)
            {
                _customer = _customer.Where(p =>
                    p.Id == options.CustomerId);
            }
            return _customer;
        }
    }
}
