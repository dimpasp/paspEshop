using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class SearchCustomerOptions
    {
        public string VatNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedFrom { get; set; }
        public DateTimeOffset CreatedTo { get; set; }
        public int? CustomerId { get; set; }
    }
}
