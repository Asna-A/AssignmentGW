
using CardManagementApp.models;
using CardManagementApp.models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CardManagementApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new CardManagementContext())
            {

               

                List<Customer> customers = new List<Customer>();

                Customer customer1 = new Customer(getCustId(),"Iza", "East Fort,Kochi", "Iza@gmail.com", "9778523645");
                customers.Add(customer1);
                context.Customers.Add(customer1);
                context.SaveChanges();

                var account1 = new Account {Id="Acc"+getAccId().ToString(), AccountNumber= "1111", AccountType= AccountType.Debit,Balance= 1000.00 ,Customer=customer1};
                context.Accounts.Add(account1);
                context.SaveChanges();

                var account2 = new Account { Id = "Acc" + getAccId().ToString(),AccountNumber = "2222", AccountType = AccountType.Credit, Balance = 2000.00, Customer= customer1 };
                context.Accounts.Add(account2);
                context.SaveChanges();

                




                Customer customer2 = new Customer(getCustId(),"Milan", "west fort,bangalore", "milan@gmail.com", "8045216953");
                customers.Add(customer2);
                context.Customers.Add(customer2);
                context.SaveChanges();


                var account3 = new Account { Id = "Acc" + getAccId().ToString(), AccountNumber = "3333", AccountType = AccountType.Debit, Balance = 1000.00, Customer = customer2 };
                context.Accounts.Add(account3);
                context.SaveChanges();



                Customer customer3 = new Customer(getCustId(),"Joseph", "North,New York", "jose@gmail.com", "99236589652");
                customers.Add(customer3);
                context.Customers.Add(customer3);
                context.SaveChanges();

                var account4 = new Account {Id="Acc"+getAccId().ToString(),AccountNumber= "5555", AccountType= AccountType.Credit, Balance= 20.00, Customer=customer3};
                context.Accounts.Add(account4);
                context.SaveChanges();

                var account5 = new Account{Id="Acc"+getAccId().ToString(),AccountNumber="6666",AccountType= AccountType.Debit, Balance=400.00,Customer=customer3};
                context.Accounts.Add(account5);
                context.SaveChanges();

                var account6 = new Account{Id="Acc"+getAccId().ToString(),AccountNumber="7777",AccountType= AccountType.Debit,Balance= 6000.00,Customer=customer3};
                context.Accounts.Add(account6);
                context.SaveChanges();

                var account7 = new Account{Id="Acc"+getAccId().ToString(),AccountNumber="4444",AccountType= AccountType.Debit,Balance= 1000.00,Customer=customer3};
                context.Accounts.Add(account7);
                context.SaveChanges();
             



               

                Transaction transaction1 = new Transaction{Id = "Tran" + getTranId().ToString(), TransactionType = TransactionType.Deposit, Amount = 1000, Description = "money deposited", Account = account1 };
                transaction1.updateBalance();
                context.Transactions.Add(transaction1);
                context.SaveChanges();


                Transaction transaction2 = new Transaction{Id="Tran"+getTranId().ToString(),TransactionType=TransactionType.Withdrawal,Amount= 200, Description="money withdrawed", Account = account1};
                transaction2.updateBalance();
                context.Transactions.Add(transaction2);
                context.SaveChanges();

                Transaction transaction5 = new Transaction{Id="Tran"+getTranId().ToString(),TransactionType= TransactionType.Withdrawal,Amount= 200,Description= "money withdrawed",Account=account2};
                transaction5.updateBalance();
                context.Transactions.Add(transaction5);
                context.SaveChanges();

                Transaction transaction3 = new Transaction{Id="Tran"+getTranId().ToString(),TransactionType=TransactionType.Deposit,Amount= 1000,Description= "money deposited",Account= account3};
                transaction3.updateBalance();
                context.Transactions.Add(transaction3);
                context.SaveChanges();

                Transaction transaction4 = new Transaction{Id="Tran"+getTranId().ToString(),TransactionType= TransactionType.Withdrawal,Amount= 200, Description="money withdrawed", Account=account5};
                transaction4.updateBalance();
                context.Transactions.Add(transaction4);
                context.SaveChanges();

                
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

                int getCustId()
                {

                    return context.Customers.Any()?
                    int.Parse(context.Customers.OrderByDescending(e => e.Id)
                    .First().Id.Substring(4)) + 1 : 1001;

                    

                    
                   
                }
                int getAccId()
                {

                    return context.Accounts.Any() ?
                    int.Parse(context.Accounts.OrderByDescending(e => e.Id)
                    .First().Id.Substring(3)) + 1 : 1001;
                    
                }

                int getTranId()
                {
                    return context.Transactions.Any() ?
                    int.Parse(context.Transactions.OrderByDescending(e => e.Id)
                    .First().Id.Substring(4)) + 1 : 1001;


                }   
                printDetailsCustomer(context, "Cust1002");
                printDetailsAccount(context, "Acc1005");
            }
            


        }
        static void printDetailsCustomer(CardManagementContext context,string Id)
        {

            var customer = context.Customers.FirstOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            
            Console.WriteLine($"ID: {customer.Id}, CustomerName: {customer.CustomerName}, CustomerAddress: {customer.CustomerAddress}, Email: {customer.Email}, PhoneNumber: {customer.PhoneNumber}");

            
            foreach (var account in customer.Accounts)
            {
                Console.WriteLine($"AccountNumber: {account.AccountNumber}, AccountType: {account.AccountType}, Balance: {account.Balance}");
            }
        }
        static void printDetailsAccount(CardManagementContext context, string Id)
        {
            
            var account = context.Accounts.FirstOrDefault(c => c.Id == Id);

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }
             Console.WriteLine($"AccountNumber: {account.AccountNumber}, AccountType: {account.AccountType}, Balance: {account.Balance}");
            
        }
    }
}
