

namespace Card.Domain.Entity
{
    public class Customer
    {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
