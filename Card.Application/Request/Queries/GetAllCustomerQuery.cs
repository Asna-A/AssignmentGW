//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Card.Application.DTO;
//using Card.Domain.Entity;
//using MediatR;
//using Microsoft.EntityFrameworkCore;

//namespace Card.Application.Request.Queries
//{
//    public class GetAllCustomerQuery:IRequest<List<GetAllCustomerDTO>>
//    {
    
//    }

//    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustomerDTO>>
//    {
//        public Task<List<GetAllCustomerDTO>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
//        {
//           var customers=_context.Customers
//        }
//    }
//}
