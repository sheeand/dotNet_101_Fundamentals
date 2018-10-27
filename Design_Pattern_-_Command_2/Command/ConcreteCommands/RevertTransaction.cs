using Design_Pattern___Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command.ConcreteCommands
{
    class RevertTransaction : ICommand
    {
        public int TransactionID { get; set; }
        public bool ValidTransaction { get; set; }
        public decimal TransactionValue { get; set; }
        public int OldID { get; set; }
        private IAccount _account;

        public RevertTransaction(IAccount account, decimal oldValue, int id, int oldId)
        {
            TransactionID = id;
            TransactionValue = oldValue;
            _account = account;
            OldID = oldId;
        }

        public bool Execute()
        {
            if (_account.Revert(TransactionValue))
            {
                ValidTransaction = true;
                return true;
            }
            else return false;
        }
    }
}
