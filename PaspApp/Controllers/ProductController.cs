using Microsoft.AspNetCore.Mvc;
using PaspCore.Services;
using PaspCore.Model;

namespace PaspCore.Controllers
{

    public class ProductController : Controller
    {
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

    }
}

