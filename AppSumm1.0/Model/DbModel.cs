using System;
using System.Collections.Generic;
using System.Text;

namespace AppSumm1._0.Model
{
    public  class DbModel
    {
        public decimal Summ { get; set; }
        public List<Log> Logs { get; set; } = new List<Log>();
    }
}
