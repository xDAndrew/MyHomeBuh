using AppSumm1._0.Model;

namespace AppSumm1._0.Interface
{
    public interface IRepository
     {
        void SaveHistory(DbModel dbModel);
        DbModel LoadHistory();
     }
}
