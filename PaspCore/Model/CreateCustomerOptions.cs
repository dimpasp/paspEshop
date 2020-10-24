using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class CreateCustomerOptions
    {
        public string VatNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
