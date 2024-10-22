using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Domain.Entity;

namespace Card.Application.DTO
{
    
    public class AddCustomerDTO
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<AddAccountDTO> Accounts { get; set; }



    }
}
