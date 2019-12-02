using AppSumm1._0.Model;
using System.Collections.Generic;

namespace AppSumm1._0.Interface
{
    public interface IRepository
    {
        void SaveHistory(DbModel dbModel);
        DbModel LoadHistory();
        void SaveCategories(List<Category> category);
        IEnumerable<Category> LoadCategories();
    }
}
