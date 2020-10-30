using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
   public  class OrderProduct
    {
        /// <summary>
        /// 
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Product Product { get; set; }
    }
}
