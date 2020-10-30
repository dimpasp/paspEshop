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
            CreateCustomer options);

        IQueryable<Customer> SearchCustomers(
            SearchCustomer options);

        bool UpdateCustomer(int id,
            UpdateCustomer options);

    }
}
