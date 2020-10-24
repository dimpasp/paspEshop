using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct { get; }
        bool AddProduct(AddProductOptions options);
        bool UpdateProduct(string productId,
            UpdateProductOptions options);
        Product GetProductById(int ProductId);
    }
}
