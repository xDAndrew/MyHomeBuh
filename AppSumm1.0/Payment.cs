// 1.  Когда я добавляю или отнимаю деньги, я должен ввести текстовое сообщение.
//2.  Когда я вызываю метод History я должен получить историю(дату, время, сообщение сумма) 
//3.  Консольное преложения должно вывести всю мою историю (платежь красным цветом, пополнение зеленым)
using System;
using System.Collections.Generic;

namespace AppSumm1._0
{
    public class Payment:IPayment
    {
        private decimal Summ = 0;
        private List<Log> History = new List<Log>();
        public Log account;
        public decimal GetSumm()
        {
            return Summ;
        }
        public void Withdraw(Log payment)
        {
            if(Summ > 0 && Summ > payment.money)
            {
                Summ -= payment.money;
                History.Add(payment);
            } else
            Console.WriteLine("У вас не достаточно средств");
        }
        public void AddMoney(Log payment)
        {
            payment.incoment = true;
            Summ += payment.money;
            History.Add(payment);
        }
        public List<Log> GetHistory()
        {
            return History;
        }
    }
}
