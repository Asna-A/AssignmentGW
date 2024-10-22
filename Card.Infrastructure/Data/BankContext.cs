
using Microsoft.EntityFrameworkCore;

namespace Card.Infrastructure.Data
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Card.Domain.Entity.Customer> Customers { get; set; }
        public DbSet<Card.Domain.Entity.Account> Accounts { get; set; }

        public DbSet<Card.Domain.Entity.Transaction> Transactions { get; set; }





    }
}
