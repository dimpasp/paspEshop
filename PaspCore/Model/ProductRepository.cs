using PaspCore.Data;
using PaspCore.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace PaspCore.Model
{
    public class ProductRepository : IProductRepository
    {
        private readonly PaspDbContext _appDbContext;
        public ProductRepository(PaspDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Product> GetAllProduct
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        public Product GetProductById(int ProductId)
        {
            return _appDbContext.Products.FirstOrDefault(c => c.ProductId == ProductId);
        }
    }
}
