using Design_Pattern___Command_2.Command;
using Design_Pattern___Command_2.Command.ConcreteCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Invoker
{
    class AccountInvoker
    {
        // Data enters the Invoker
        // The Invoker (object) sends a Command (method) with the data to the Receiver (object) 
        // The Receiver determines "how" the command is executed

        //-- Field that allows us to pass in a command
        public ICommand GetBalanceCommand;
        public ICommand DepositCommand;
        public ICommand WithdrawCommand;
        public List<ICommand> TransactionHistory;

        //private List<ICommand> _transactionHistory;

        public AccountInvoker(ICommand getBalance, ICommand deposit, ICommand withdraw)
        {
            TransactionHistory = new List<ICommand>();
            GetBalanceCommand = getBalance;
            DepositCommand = deposit;
            WithdrawCommand = withdraw;
        }

        public void GetBalance()
        {
            GetBalanceCommand.Execute();
        }

        public void Deposit()
        {
            TransactionHistory.Add(DepositCommand);
            DepositCommand.Execute();
        }

        public void Withdraw()
        {
            TransactionHistory.Add(DepositCommand);
            WithdrawCommand.Execute();
        }
    }
}
