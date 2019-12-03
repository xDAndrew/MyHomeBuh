using AppSumm1._0.Models;
using System.Collections.Generic;

namespace AppSumm1._0.Interface
{
    public interface IPayment
     {
         void Withdraw(Log payment);
         void AddMoney(Log payment);
         List<Log> GetHistory();
         decimal GetSumm();
     }
}
