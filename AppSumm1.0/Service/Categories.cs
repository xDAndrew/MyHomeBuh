using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSumm1._0.Service
{
    public class Categories : ICategories
    {
        public Categories(IRepository categories)
        {
            _categories = categories.LoadCategories().ToList();
            repository = categories;
        }
        private List<Category> _categories;
        private IRepository repository;

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
        public void SetCategory(string category)
        {
            _categories.Add(new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = category
            });
            repository.SaveCategories(_categories);
        }
    }
}
