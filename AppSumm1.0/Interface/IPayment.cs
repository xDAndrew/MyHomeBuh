using AppSumm1._0.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSumm1._0
{
     public interface IPayment
     {
         void Withdraw(Log payment);
         void AddMoney(Log payment);
         List<Log> GetHistory();
         decimal GetSumm();
     }
}
