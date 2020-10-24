using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public interface IOrderServices
    {
        public Order CreateOrder(int customerId,
          ICollection<string> productIds);
    }
}
