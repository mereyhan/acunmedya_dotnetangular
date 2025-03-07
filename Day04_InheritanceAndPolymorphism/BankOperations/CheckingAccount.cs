using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_InheritanceAndPolymorphism.BankOperations
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance)
        {
            
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest");
        }
    }
}
