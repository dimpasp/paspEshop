using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct { get; }
        bool AddProduct(AddProduct options);
        bool UpdateProduct(string productId,
            UpdateProduct options);
        Product GetProductById(int ProductId);
    }
}
