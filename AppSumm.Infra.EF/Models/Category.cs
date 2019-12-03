using System;
using System.Collections.Generic;

namespace AppSumm.Infra.EF.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
