using AppSumm1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSumm1._0.Interface
{
    public interface ICategories
    {
        void SetCategory(string category);
        IEnumerable<Category> GetCategories();
    }
}
