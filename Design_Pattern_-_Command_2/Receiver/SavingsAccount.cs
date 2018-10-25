using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Receiver
{
    class Account
    {

        decimal balance = 40m;

        public void GetBalance()
        {
            Console.WriteLine($"The balance is ${balance}");
        }

        public void Deposit()
        {
            Console.WriteLine("Depositing");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdrawing");
        }

        internal void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
