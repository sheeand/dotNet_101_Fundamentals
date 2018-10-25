using Design_Pattern___Command_2.Command;
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
        private ICommand _getBalance;
        private ICommand _deposit;
        private ICommand _withdraw;

        //-- There are two Constructors
        //-- The first Constructor is used when the Invoker is originally created on a brand new Account
        public AccountInvoker(ICommand getBalance, ICommand deposit, ICommand withdraw)
        {
            _getBalance = getBalance;
            _deposit = deposit;
            _withdraw = withdraw;
        }

        //-- The second Constructor is used anytime after the initial creation and allows the Concrete Commands to be updated
        //TODO: Create public methods that allow these to be updated in existing Invoker
        public AccountInvoker(ICommand getBalance, ICommand deposit, ICommand withdraw, List<ICommand> transactionList)
        {
            _getBalance = getBalance;
            _deposit = deposit;
            _withdraw = withdraw;
            _
        }

        public void GetBalance()
        {
            _getBalance.Execute();
        }

        public void Deposit(decimal amount)
        {
            _deposit.Execute(amount);
        }

        public void Withdraw(decimal amount)
        {
            _withdraw.Execute(amount);
        }
    }
}
