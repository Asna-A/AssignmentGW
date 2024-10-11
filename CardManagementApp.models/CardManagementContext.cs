using CardManagementApp.models.Models;
using Microsoft.EntityFrameworkCore;

namespace CardManagementApp.models
{
    public class CardManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CardAppDataBase;User Id=sa;Password=Pass@word1;TrustServerCertificate=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
