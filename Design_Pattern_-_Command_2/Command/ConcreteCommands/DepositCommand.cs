using Design_Pattern___Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command.ConcreteCommands
{
    class DepositCommand : ICommand
    {
        public bool ValidTransaction { get; set; }
        public int TransactionID { get; set; }
        public decimal TransactionValue { get; set; }
        private IAccount _account;
        private SavingsAccount account;

        public DepositCommand(IAccount account, decimal value, int id)
        {
            TransactionID = id;
            _account = account;
            TransactionValue = value;
        }

        public DepositCommand(SavingsAccount account)
        {
            this.account = account;
        }

        public bool Execute()
        {
            if (_account.Deposit(TransactionValue))
            {
                ValidTransaction = true;
                return true;
            }
            else return false;
        }

        public override string ToString() => $"{TransactionID}. Deposited ${TransactionValue}. Valid: {ValidTransaction}";
    }
}
