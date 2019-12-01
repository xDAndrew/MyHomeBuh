//1. Создать интерфейс IStatistic  и реализовать класс
//2. Реализовать метод который получает историю платежей номер месяца , возращает  полную сумму затрат и пополней за этот месяц 
//3. Реализовать метод, который получает историю платежей и возращает разницу между доходом и расходом 
//4. Создать ветку, комит и пул реквест  
using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using System;
using System.Collections.Generic;

namespace AppSumm1._0
{
    public class Payment:IPayment
    {
        public Payment( IRepository repository)
        {
            _repository = repository;
            Summ = repository.LoadHistory().Summ;
            History = repository.LoadHistory().Logs;
        }
        private IRepository _repository { get; set; }
        private decimal Summ = 0;
        private List<Log> History = new List<Log>();
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
                _repository.SaveHistory(new DbModel() { Summ=Summ, Logs=History});
            } else
            Console.WriteLine("У вас не достаточно средств");
        }
        public void AddMoney(Log payment)
        {
            payment.incoment = true;
            Summ += payment.money;
            History.Add(payment);
            _repository.SaveHistory(new DbModel() { Summ = Summ, Logs = History});
        }
        public List<Log> GetHistory()
        {
            return History;
        }
        
    }
}
