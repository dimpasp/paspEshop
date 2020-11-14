using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class SimilarProduct
    {
        /// <summary>
        /// 
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ImageThubnail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }
    }
}
