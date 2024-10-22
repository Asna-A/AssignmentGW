using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Api.Controllers;
using Card.Domain.Entity;
using Card.Infrastructure.Data;
using MediatR;

namespace Card.Application.Request.Commands
{
    public class AddTransactionCommand : IRequest<int>
    {
        public DateTime TransactionDate { get; set; }

        public TransactionType TransactionType;
        public double Amount { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
    }
    public class AddTransactionCommandHandler : IRequestHandler<AddTransactionCommand, int>
    {
        private readonly BankContext _context;

        public AddTransactionCommandHandler(BankContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddTransactionCommand request, CancellationToken cancellationToken)
        {
            var account= await _context.Accounts.FindAsync(request.AccountId);
            var transaction = new Transaction
            {
                Account = account,
                TransactionType = request.TransactionType,
                Amount = request.Amount,
                Description = request.Description,
                TransactionDate = request.TransactionDate
            };
            transaction.updateBalance();
            _context.Transactions.Add(transaction);
            return await _context.SaveChangesAsync();
        }
    }
}
