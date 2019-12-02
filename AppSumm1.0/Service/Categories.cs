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
        private List<Category> categories;
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
        public void SetCategories(Category category)
        {
            categories.Add(new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = category.CategoryName
            });
        }
    }
}
