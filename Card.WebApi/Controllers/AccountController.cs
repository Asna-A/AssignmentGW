using Card.Application.DTO;
using Card.Application.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Card.Api.Controllers
{
    [Route("api/customer/{CustomerId}/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<int> AddAccount(int CustomerId,AddAccountDTO dto)

        {
            var command = new AddAccountCommand
            {
                AccountNumber = dto.AccountNumber,
                AccountType = dto.AccountType,
                Balance = dto.Balance,
                CustomerId = CustomerId
            };
            
            return await _mediator.Send(command);
        }
    }
}
