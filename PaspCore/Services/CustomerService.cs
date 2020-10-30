using PaspCore.Data;
using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaspCore.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly PaspDbContext _appDbContext;
        public Customer CreateCustomer(CreateCustomer options)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> SearchCustomers(SearchCustomer options)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(int id, UpdateCustomer options)
        {
            throw new NotImplementedException();
        }
    }
}
