
using Card.Application.DTO;
using Card.Domain.Entity;
using Card.Infrastructure.Data;
using MediatR;


namespace Card.Application.Request.Commands
{
    public class AddAccountCommand:IRequest<int>
    {
        public string AccountNumber { get; set; }
        public Domain.Entity.AccountType AccountType { get; set; }
        public double Balance { get; set; }
        
        public int  CustomerId { get; set; }


        public List<AddTransactionDTO> Transactions { get; set; }
    }
    public class AddAccountCommandHandler : IRequestHandler<AddAccountCommand, int>
    {
        private readonly BankContext _context;

        
        public AddAccountCommandHandler(BankContext context)
        {
            _context = context;
        }


        public async Task<int> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.FindAsync(request.CustomerId);
            var account = new Account {

                AccountNumber = request.AccountNumber,
                AccountType = request.AccountType,
                Balance = request.Balance,
                Customer = customer
            };
            _context.Accounts.Add(account);
            return await _context.SaveChangesAsync();

              
        }

        
    }
}

        

        
    
    
