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
        public bool ValidTransaction { get; set; }
        public int TransactionID { get; set; }
        public decimal TransactionValue { get; set; }
        private IAccount _account;

        public WithdrawCommand(IAccount account, decimal value, int id)
        {
            TransactionID = id;
            _account = account;
            TransactionValue = value;
        }

        public bool Execute()
        {
            if (_account.Withdraw(TransactionValue))
            {
                ValidTransaction = true;
                return true;
            }
            else return false;
        }
    }
}
