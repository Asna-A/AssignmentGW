using Card.Application.DTO;
using Card.Application.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Card.Api.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<int> AddCustomer(AddCustomerDTO dto)
        {
            var command = new AddCustomerCommand
            {
                CustomerName = dto.CustomerName,
                CustomerAddress = dto.CustomerAddress,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                Accounts = dto.Accounts
            };
            return await _mediator.Send(command);
        }

        

    }
}
