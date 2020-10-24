using PaspCore.Data;
using PaspCore.Model;
using PaspCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PaspDbContext _appDbContext;

        public CategoryRepository(PaspDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;

    }
}
