using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagementApp.models.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer
    }
    public class Transaction
    {
        private static int count = 1000;
        public string Id { get; set; }
        public DateTime TransactionDate { get; set; }

        public TransactionType TransactionType;
        public double Amount { get; set; }
        public string Description { get; set; }
        public Account Account { get; set; }
        
        public Transaction()
        {
            Id = "Txn" + count++;
            TransactionDate = DateTime.Now;

        }



        public void updateBalance()
        {
            if (TransactionType == TransactionType.Deposit)
            {
                Account.Balance += Amount;
            }
            else if (TransactionType == TransactionType.Withdrawal)
            {
                if (Account.Balance >= Amount)
                {
                    Account.Balance -= Amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }
            else if (TransactionType == TransactionType.Transfer)
            {
                if (Account.Balance >= Amount)
                {
                    Account.Balance -= Amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }

        }
       
        public void PrintDetailsTransaction()
        {
            Console.WriteLine($"Id:{Id},TransactionDate:{TransactionDate},TransactionType:{TransactionType},Amount:{Amount},Description{Description},Acocunt:{Account}");
        }
        
    }
}
