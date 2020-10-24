using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class AddProductOptions
    {
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }
    }
}
