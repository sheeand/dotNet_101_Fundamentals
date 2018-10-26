using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Receiver
{
    //-- Class that implements the IAccount interface and will act as the Receiver

    class SavingsAccount : IAccount
    {
        public decimal Balance { get; set; }

        public bool GetBalance()
        {
            Console.WriteLine($"The current savings account balance is ${Balance}");
            return true;
        }

        public bool Deposit(decimal value)
        {
            var oldBalance = Balance;
            Balance += value;

            if (oldBalance != Balance) return true;
            else return false;
        }

        public bool Withdraw(decimal value)
        {
            var oldBal = Balance;

            if ((Balance - value) >= 0)
            {
                Balance -= value;
                Console.WriteLine($"New account balance is: ${Balance}.");
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawal could not go through.");
                return false;
            }
        }

        //bool IAccount.Deposit(decimal value)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
