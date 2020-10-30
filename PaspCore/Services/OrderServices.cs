using PaspCore.Data;
using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaspCore.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ICustomerServices customers_;
        private readonly PaspDbContext _appDbContext;
        public OrderServices(
           ICustomerServices customers,
           PaspDbContext context)
        {
            _appDbContext = context;
            customers_ = customers;
        }
        public Order CreateOrder(int customerId, ICollection<string> productIds)
        {
            if (customerId <= 0)
            {
                return null;
            }

            if (productIds == null ||
              productIds.Count == 0)
            {
                return null;
            }
            var customer = customers_.SearchCustomers(
              new SearchCustomer()
              {
                  CustomerId = customerId
              })
              .Where(c => c.IsActive)
              .SingleOrDefault();

            if (customer == null)
            {
                return null;
            }

            var products = _appDbContext
                .Set<Product>()
                .Where(p => productIds.Contains(p.ProductId.ToString()))
                .ToList();
            var order = new Order()
            {
                Customer = customer
            };

            foreach (var p in products)
            {
                order.Products.Add(
                    new OrderProduct()
                    {
                        ProductId = p.ProductId.ToString()
                    });
            }
            _appDbContext.Add(order);
            return order;
        }
    }
}
