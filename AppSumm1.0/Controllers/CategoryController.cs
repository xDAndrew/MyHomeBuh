using System.Collections.Generic;
using AppSumm1._0.Interface;
using AppSumm1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppSumm1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategories _categories;
        public CategoryController(ICategories categories)
        {
            _categories = categories;
        }

        [HttpGet]
        [Route("categories")]
        public IEnumerable<Category> GetCategories()
        {
            return _categories.GetCategories();
        }

        [HttpPost]
        [Route("category")]
        public void SetCategory(string category)
        {
            _categories.SetCategory(category);
        }

    }
}