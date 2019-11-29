using System;
using System.Collections.Generic;
using System.Text;

namespace AppSumm1._0
{
     public class Log
     { 
        public decimal money { get; set; }
        public string message { get; set; }
        public string date = DateTime.Now.ToString();
        public bool incoment { get; set; }
     }
}
