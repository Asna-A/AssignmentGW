using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Domain.Entity;

namespace Card.Application.DTO
{
    
    public class AddAccountDTO
    {
       
            public string AccountNumber { get; set; }
            public AccountType AccountType { get; set; }
            public double Balance { get; set; }
       
            public List<AddTransactionDTO> Transactions { get; set; }

    }
}
