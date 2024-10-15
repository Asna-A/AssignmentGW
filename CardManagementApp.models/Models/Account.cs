using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CardManagementApp.models.Models
{
    public enum AccountType
    {
        Debit,
        Credit
    }
    public class Account
    {
        
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType{  get; set; }
        public double Balance{  get; set; }
        public List<Transaction> transactions { get; set; }
       
        public Customer Customer { get; set; }
        public Account()
        {
            
            transactions = new List<Transaction>();

        }
        
        

        public void printTransactionDetails()
        {
            foreach (Transaction transaction in transactions)
            {
                {
                    Console.WriteLine($"ID:{transaction.Id},TransactionDate:{transaction.TransactionDate},TransactionType:{transaction.TransactionType},amount:{transaction.Amount},description:{transaction.Description}");
                }
            }


        }


    }
}
    
