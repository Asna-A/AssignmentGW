
using CardManagementApp.models;
using CardManagementApp.models.Models;
using Microsoft.EntityFrameworkCore;

namespace CardManagementApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new CardManagementContext())
            {
                List<Customer> customers = new List<Customer>();
                Customer customer1 = new Customer("Iza", "East Fort,Kochi", "Iza@gmail.com", "9778523645");
                var account1 = new Account { AccountNumber= "1111", AccountType= AccountType.Debit,Balance= 1000.00 ,Customer=customer1};
                context.Accounts.Add(account1);
                var account2 = new Account { AccountNumber = "2222", AccountType = AccountType.Credit, Balance = 2000.00, Customer= customer1 };
                context.Accounts.Add(account2);
                customers.Add(customer1);
                Customer customer2 = new Customer("Milan", "west fort,bangalore", "milan@gmail.com", "8045216953");
                var account3 = new Account { AccountNumber = "3333", AccountType = AccountType.Debit, Balance = 1000.00, Customer = customer2 };
                context.Accounts.Add(account3);
                customers.Add(customer2);
                Customer customer3 = new Customer("Joseph", "North,New York", "jose@gmail.com", "99236589652");
                var account4 = new Account {AccountNumber= "5555", AccountType= AccountType.Credit, Balance= 20.00, Customer=customer3};
                context.Accounts.Add(account4);
                var account5 = new Account{AccountNumber="6666",AccountType= AccountType.Debit, Balance=400.00,Customer=customer3};
                context.Accounts.Add(account5);
                var account6 = new Account{AccountNumber="7777",AccountType= AccountType.Debit,Balance= 6000.00,Customer=customer3};
                context.Accounts.Add(account6);
                var account7 = new Account{AccountNumber="4444",AccountType= AccountType.Debit,Balance= 1000.00,Customer=customer3};
                context.Accounts.Add(account7);
                customers.Add(customer3);

                context.Customers.AddRange(customers);

                try
                {
                    context.SaveChanges();
                    Console.WriteLine("Changes saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving changes: {ex.Message}");
                    Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                }





                Transaction transaction1 = new Transaction { TransactionType = TransactionType.Deposit, Amount = 1000, Description = "money deposited", Account = account1 };
                transaction1.updateBalance();
                context.Transactions.Add(transaction1);
                Transaction transaction2 = new Transaction{TransactionType=TransactionType.Withdrawal,Amount= 200, Description="money withdrawed", Account = account1};
                transaction2.updateBalance();
                context.Transactions.Add(transaction2);
                Transaction transaction5 = new Transaction{TransactionType= TransactionType.Withdrawal,Amount= 200,Description= "money withdrawed",Account=account2};
                transaction5.updateBalance();
                context.Transactions.Add(transaction5);
                Transaction transaction3 = new Transaction{TransactionType=TransactionType.Deposit,Amount= 1000,Description= "money deposited",Account= account3};
                transaction3.updateBalance();
                context.Transactions.Add(transaction3);
                Transaction transaction4 = new Transaction{TransactionType= TransactionType.Withdrawal,Amount= 200, Description="money withdrawed", Account=account5};
                transaction4.updateBalance();
                context.Transactions.Add(transaction4);

                try
                {
                    context.SaveChanges(); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                foreach (Customer customer in customers)
                {
                    customer.PrintDetails();
                    Console.WriteLine();
                }

                
                foreach (Customer customer in context.Customers.Include(c => c.Accounts).ThenInclude(a=>a.transactions))
                {
                    customer.PrintDetails();
                    Console.WriteLine();

                    foreach (Account account in customer.Accounts)
                    {
                        Console.WriteLine($"Account Number: {account.AccountNumber}");
                        account.printTransactionDetails();
                        Console.WriteLine();
                    }
                }
                
            }



        }
    }
}
