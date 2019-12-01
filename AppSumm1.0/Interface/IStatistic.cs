using AppSumm1._0.Model;

namespace AppSumm1._0.Interface
{
    public interface IStatistic
    {
        MonthHistory HistoryMonth(int number_month);
        decimal DifferenceIncoming(int number_month);
     }
}
