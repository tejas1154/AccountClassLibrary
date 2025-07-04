using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLib
{
    public class Account
    {
        public string AccountHolder {  get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(string accountHolder,  string accountNumber, double balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
                Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if(amount >0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {AccountHolder}, Account Number: {AccountNumber}, Balance: {Balance}";
        }
    }
}
