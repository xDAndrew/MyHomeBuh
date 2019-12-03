using System.Collections.Generic;

namespace AppSumm1._0.Models
{
    public  class DbModel
    {
        public decimal Summ { get; set; }
        public List<Log> Logs { get; set; } = new List<Log>();
    }
}
