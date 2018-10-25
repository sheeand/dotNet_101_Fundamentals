using Design_Pattern___Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command.ConcreteCommands
{
    class WithdrawCommand : ICommand
    {
        private Account account;

        public WithdrawCommand(Account account)
        {
            this.account = account;
        }

        public void Execute()
        {
            account.Withdraw();
        }

        //private Account _account;

        //public WithdrawCommand(Account account)
        //{
        //    _account = account;
        //}

        //public void Execute()
        //{
        //_account.Withdraw();
        //}
    }
}
