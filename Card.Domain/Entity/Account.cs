

namespace Card.Domain.Entity
{
    public enum AccountType
    {
        Debit,
        Credit
    }
    public class Account
    {

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }
        public Customer Customer { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
