using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.BankOperations
{
    class BankAccount
    {
        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public virtual void CalculateInterest() { }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}");
        }
    }
}
