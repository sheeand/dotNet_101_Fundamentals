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
        public bool ValidTransaction { get; set; }
        public int TransactionID { get; set; }
        public decimal TransactionValue { get; set; }
        private IAccount _account;

        public GetBalanceCommand(IAccount account, int id)
        {
            TransactionID = id;
            _account = account;
        }

        public bool Execute()
        {
            if (_account.GetBalance())
            {
                ValidTransaction = true;
                return true;
            }
            else return false;
        }
        public override string ToString() => $"{TransactionID}. Balance check. Valid: {ValidTransaction}";

    }
}
