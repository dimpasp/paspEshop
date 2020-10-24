using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaspCore.Services
{
   public interface ICustomerServices
    {
        Customer CreateCustomer(
            CreateCustomerOptions options);

        IQueryable<Customer> SearchCustomers(
            SearchCustomerOptions options);

        bool UpdateCustomer(int id,
            UpdateCustomerOptions options);

    }
}
