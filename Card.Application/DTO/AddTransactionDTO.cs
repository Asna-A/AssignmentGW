using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card.Domain.Entity;

namespace Card.Application.DTO
{
    public class AddTransactionDTO
    {
        public DateTime TransactionDate { get; set; }

        public TransactionType TransactionType;
        public double Amount { get; set; }
        public string Description { get; set; }
        

    }
}
