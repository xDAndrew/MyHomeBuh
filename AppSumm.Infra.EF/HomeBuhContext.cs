using AppSumm.Infra.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSumm.Infra.EF
{
    public class HomeBuhContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyHomeBuhBD.db");
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
