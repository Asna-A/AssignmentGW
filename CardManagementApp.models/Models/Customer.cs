using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagementApp.models.Models
{
    public class Customer
    {
        private static int count = 1000;
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(string customerName, string customerAddress, string email, string phoneNumber)
        {
            Id = "Cust" + count++;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Accounts = new List<Account>();

        }
        

        public void PrintDetails()
        {
            Console.WriteLine($"ID:{Id}CustomerName:{CustomerName},customerAddress:{CustomerAddress},email:{Email},phoneNumber:{PhoneNumber}");
            foreach (Account account in Accounts) Console.WriteLine($"accountNumber:{account.AccountNumber},accountType:{account.AccountType},balance:{account.Balance}");
        }


    }
}
