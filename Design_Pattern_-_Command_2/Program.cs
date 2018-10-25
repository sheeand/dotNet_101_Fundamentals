using Design_Pattern___Command_2.Command;
using Design_Pattern___Command_2.Command.ConcreteCommands;
using Design_Pattern___Command_2.Invoker;
using Design_Pattern___Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Receiver
            Account account = new Account();

            //-- Concrete commands
            ICommand depostCommand = new DepositCommand(account);
            ICommand withdrawCommand = new WithdrawCommand(account);
            ICommand getBalanceCommand = new GetBalanceCommand(account);

            //-- Invoker 
            AccountInvoker accountInvoker = new AccountInvoker(getBalanceCommand, depostCommand, withdrawCommand);

            accountInvoker.GetBalance();
            accountInvoker.Deposit(10);
            //accountInvoker.Withdraw();
        }
    }
}
