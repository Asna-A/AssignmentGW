using System.Linq;
using Card.Application.DTO;
using Card.Domain.Entity;
using Card.Infrastructure.Data;
using MediatR;

namespace Card.Api.Controllers
{
    public class AddCustomerCommand:IRequest<int>
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<AddAccountDTO> Accounts { get; set; }

    }
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, int>
    {
        private readonly BankContext _context;

        public AddCustomerCommandHandler(BankContext context)
        {
            _context=context;
        }

        

        public async Task<int> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                CustomerName = request.CustomerName,
                CustomerAddress = request.CustomerAddress,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Accounts = request.Accounts.Select(a => new Account
                {
                    AccountNumber = a.AccountNumber,
                    AccountType = a.AccountType,
                    Balance = a.Balance,
                    Transactions = a.Transactions.Select(t =>new Transaction
                    {

                        TransactionDate = t.TransactionDate,
                        TransactionType = t.TransactionType,
                        Amount = t.Amount,
                        Description = t.Description
                    }).ToList()
                }).ToList()
            }; 
            _context.Customers.Add(customer);
            return await _context.SaveChangesAsync();
        }
    }
}