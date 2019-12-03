using AppSumm1._0.Models;
using System.Collections.Generic;

namespace AppSumm1._0.Interface
{
    public interface ICategories
    {
        void SetCategory(string category);
        IEnumerable<Category> GetCategories();
    }
}
