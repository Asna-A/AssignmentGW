using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagementApp.models.Models
{
    public class Customer
    {
        
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> Accounts { get; set; }
        public Customer()
        {
            
        }
        public Customer(int tempid,string customerName, string customerAddress, string email, string phoneNumber)
        {
            Id = "Cust" + tempid.ToString();
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
