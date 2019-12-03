
namespace AppSumm.Infra.EF.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Money { get; set; }
        public  int Account_id { get; set; }
        public int Category_id { get; set; }
    }
}
