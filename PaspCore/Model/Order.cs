using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string DeliveryAddress { get; set; }
        public ICollection<OrderProduct> Products { get; set; }

        public Order()
        {
            Products = new List<OrderProduct>();
        }
    }
}
