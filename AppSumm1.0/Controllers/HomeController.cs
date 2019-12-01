using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppSumm1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPayment _payment;

        public HomeController(IPayment payment)
        {
            _payment = payment;
        }

        [HttpGet]
        [Route("history")]
        public IEnumerable<Log> GetHistory()
        {
            return _payment.GetHistory();
        }
    }
}
