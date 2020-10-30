using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class SearchCustomer
    {
        /// <summary>
        /// 
        /// </summary>
        public string VatNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset CreatedFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset CreatedTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? CustomerId { get; set; }
    }
}
