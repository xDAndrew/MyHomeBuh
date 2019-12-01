using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using System.Linq;

namespace AppSumm1._0.Service
{
    public class Statistic:IStatistic
    {
        public Statistic(IPayment payment)
        {
          _payment=payment;
        }
        private IPayment _payment;
        public MonthHistory HistoryMonth(int number_month)
        {

            var monthHistory = new MonthHistory();
            foreach (var item in _payment.GetHistory().Where(x => x.date.Month == number_month))
            {
                if (item.incoment)
                {
                    monthHistory.SummIncoming += item.money;
                }
                else
                    monthHistory.SummOutcoming += item.money;
            }
            return monthHistory;
        }
        public decimal DifferenceIncoming(int number_month)
        {
           MonthHistory history=   HistoryMonth(number_month);
           return history.SummIncoming - history.SummOutcoming;
        }
    }
}
