using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public class IProductRepository
    {
        IEnumerable<Product> GetAllProduct { get; }
    }
}
