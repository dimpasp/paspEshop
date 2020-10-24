using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class UpdateCustomerOptions
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool? Active { get; set; }
        public bool? Phone { get; set; }
    }
}
