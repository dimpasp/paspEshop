using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class UpdateCustomer
    {
        /// <summary>
        /// 
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Phone { get; set; }
    }
}
