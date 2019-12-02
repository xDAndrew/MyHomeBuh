using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppSumm1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPayment _payment;
        private readonly IStatistic _statistic;

        public HomeController(IPayment payment, IStatistic statistic)
        {
            _payment = payment;
            _statistic = statistic;
        }

        [HttpGet]
        [Route("history")]
        public IEnumerable<Log> GetHistory()
        {
            return _payment.GetHistory();
        }
        [HttpGet]
        [Route("summ")]
        public decimal GetSumm()
        {
            return _payment.GetSumm();
        }
        [HttpGet]
        [Route("MonthHistory")]
        public string GetStatistic(int month)
        {
            var history = _statistic.HistoryMonth(month);
            return $"Сумма доходов: {history.SummIncoming} Сумма расходов:{history.SummOutcoming}";
        }
        [HttpGet]
        [Route("DifferenceIncoming")]
        public string GetDifferenceIncoming(int month)
        {
           return $"Разница за этот месяц составила: {_statistic.DifferenceIncoming(month)}";
        }
    }
}
