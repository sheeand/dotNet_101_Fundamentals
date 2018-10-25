using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Receiver
{
    interface IAccount
    {
        // property
        decimal Balance { get; set; }

        // methods
        bool GetBalance();
        bool Deposit(decimal value);
        bool Withdraw(decimal value);
    }
}
