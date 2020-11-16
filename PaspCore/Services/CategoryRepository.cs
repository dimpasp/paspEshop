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
        //public IEnumerable<Category> GetAllCategories => new List<Category>
        //{
        //    new Category
        //    {
        //        CategoryId=1,
        //        CategoryName="Paper",
        //        CategoryDescription="paper for use"
        //    },
        //     new Category
        //    {
        //        CategoryId=2,
        //        CategoryName="Bottle",
        //        CategoryDescription="Bottle for use"
        //    }
        //};
    }
}
