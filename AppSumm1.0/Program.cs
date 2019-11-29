using System;
using System.IO;
namespace AppSumm1._0
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IPayment payment = new Payment(new Repository());
                      
            payment.AddMoney(new Log() { money=125, message="Украл"});
            payment.AddMoney(new Log() { money = 125, message = "Аванс" });
            payment.AddMoney(new Log() { money = 125, message = "Зарплата" });
            payment.Withdraw(new Log() { money = 24, message = "Купил 10 пачек презиков" });
            payment.Withdraw(new Log() { money = 12, message="Купил кушать"});
            payment.AddMoney(new Log() { money = 1500, message = "Отдали долг" });
                     
            foreach (var item in payment.GetHistory())
            {
                if (item.incoment)
                { 
                Console.ForegroundColor = ConsoleColor.Green;
                }
                else { Console.ForegroundColor = ConsoleColor.Red; }
                Console.WriteLine($"Остаток: {item.money} {item.message} Дата: {item.date}");
                Console.ResetColor();
            }
            Console.WriteLine($"Остаток денег:{payment.GetSumm()}$");
         }
    }
}
