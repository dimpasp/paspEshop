using Microsoft.AspNetCore.Mvc;
using PaspCore.Services;
using PaspCore.Model;
using PaspCore.Data;
using System.Linq;

namespace PaspCore.Controllers
{

    public class ProductController : Controller
    {
        private PaspDbContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            var ProductListViewModel = new ProductListViewModel();
            ProductListViewModel.Products = _productRepository.GetAllProduct;
            ProductListViewModel.CurrentCategory = "paper";
            return View(ProductListViewModel);
        }

        public IQueryable<Product> SearchProduct(SearchProduct options)
        {
            var product_ = _context
                .Set<Product>()               
                .AsQueryable();

            if (options == null)
            {
                return null;
            }

            if (!string.IsNullOrWhiteSpace(options.Name))
            {
                product_ = product_.Where(p =>
                    p.Name.Contains(options.Name));
            }

            if (options.ProductId > 0)
            {
                product_ = product_.Where(p =>
                    p.ProductId == options.ProductId);
            }
            return product_;
        }
        public IQueryable<Product> SimilarProduct(SimilarProduct options)
        {
            var product_ = _context
                .Set<Product>()
                .AsQueryable();

            if (options == null)
            {
                return null;
            }
            var ProductList =_productRepository.GetAllProduct;            
            foreach (Product product in ProductList)
            {
                if (options.Category == product.Category)
                {
                    product_ = product_.Where(p =>
                   p.Name.Contains(options.Name));

                    product_ = product_.Where(p =>
                   p.ImageThubnail.Contains(options.ImageThubnail));
                }
            }

            return product_;
        }
        public IActionResult Hot()
        {
            return View();
        }

    }
}

