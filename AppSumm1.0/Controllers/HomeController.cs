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
        public MonthHistory GetStatistic(int month)
        {
            return _statistic.HistoryMonth(month);
        }
        [HttpGet]
        [Route("DifferenceIncoming")]
        public decimal GetDifferenceIncoming(int month)
        {
            return _statistic.DifferenceIncoming(month);
        }
    }
}
