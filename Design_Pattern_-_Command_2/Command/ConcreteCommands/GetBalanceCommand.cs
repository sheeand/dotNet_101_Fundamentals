using Design_Pattern___Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command.ConcreteCommands
{
    class GetBalanceCommand : ICommand
    {
        private Account _account;

        public GetBalanceCommand(Account account)
        {
            _account = account;
        }

        public void Execute()
        {
            _account.GetBalance();
        }
    }
}
