using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Model
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
