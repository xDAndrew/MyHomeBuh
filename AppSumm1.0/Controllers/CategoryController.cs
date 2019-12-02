using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSumm1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(ICategories categories)
        {
            _categories = categories;
        }
        private readonly ICategories _categories;
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