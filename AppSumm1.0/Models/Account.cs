using System;

namespace AppSumm1._0.Models
{
     public class Log
     { 
        public decimal money { get; set; }
        public string message { get; set; }
        public DateTime date = DateTime.Now;
        public bool incoment { get; set; }
     }
}
