using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class BankAccount
    {
        private int accountNumber = 1;
 
        public int AccountNumber { get; }
        
        private string AccountHolderName { get; }

        private double Balance { get; set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = accountNumber++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdrawal(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                return true;
            }  
            return false;
            
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Balance: " +  Balance);
            Console.WriteLine("\n");
        }
    }

    
}
