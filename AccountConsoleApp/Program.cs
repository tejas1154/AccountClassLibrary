using System;
using AccountClassLib;

namespace AccountConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Tejas", "12355", 3000);

            Console.WriteLine("Initial Details: ");
            Console.WriteLine(a);

            a.Deposit(2000);
            Console.WriteLine("\nAfter Deposit Details: ");
            Console.WriteLine(a);

            bool result = a.Withdraw(2000); 
            Console.WriteLine(result ? "\nWithdrawal successfull" : "\nwithdrawal failed");
            Console.WriteLine(a);

        }
    }
}
