using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        
        /// here put a key
        public ICollection<OrderProduct> Products { get; set; }

        public Order()
        {
            Products = new List<OrderProduct>();
        }
    }
}
