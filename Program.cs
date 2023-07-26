using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Holder Name");
            string accountHolder = Console.ReadLine();
            BankAccount account = new BankAccount(accountHolder);

            while (true)
            {
                Console.WriteLine("Select the Process \n1. Deposit\n2. Withdrawal\n3. Exit\nEnter your Choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Depost Amount:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        account.PrintAccountDetails();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Withdrawal Amount:");
                        double withdrawalAmount = double.Parse(Console.ReadLine());
                        if (account.Withdrawal(withdrawalAmount))
                        {
                            Console.WriteLine("Withdrawal Successfull");
                            account.PrintAccountDetails();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting the Process");
                        return;                        
                    default:                        
                        Console.WriteLine("\nWrong Choice\nPlease Enter the Right Choice\n");                       
                        break;
                }
                
            }
            
        }
    }
}
