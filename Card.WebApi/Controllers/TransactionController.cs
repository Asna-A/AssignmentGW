using Card.Application.DTO;
using Card.Application.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card.Api.Controllers
{
    [Route("api/Account/{AccountId}/Transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<int> AddTransaction(int AccountId,AddTransactionDTO dto)
        {
            var command = new AddTransactionCommand
            {
                TransactionDate = dto.TransactionDate,
                TransactionType = dto.TransactionType,
                Amount = dto.Amount,
                Description = dto.Description,
                AccountId = AccountId
            };
            
            return await _mediator.Send(command);
        }
    }
}
