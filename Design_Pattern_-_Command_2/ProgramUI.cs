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
    public class ProgramUI
    {

        public void Run()
        {
            var exit = false;
            while (!exit)
            {
                var accountHistory = _invoker.TransactionHistory;
                Console.WriteLine("What would you like to do?" +
                    "\n1) Check balance" +
                    "\n2) Make a withdrawal" +
                    "\n3) Make a deposit" +
                    "\n4) Calculate interest" +
                    "\n5) See Account History" +
                    "\n6) Revert Transaction" +
                    "\n7) Exit");

                //-- Interactive code that allows the user to decide which Concrete Command they want to fire off
                int response;
                while (!int.TryParse(Console.ReadLine(), out response))
                {
                    Console.Write("Enter valid input: ");
                }
                switch (response)
                {
                    case 1:
                        DoBalance();
                        break;
                    case 2:
                        DoWithdraw();
                        break;
                    case 3:
                        DoDeposit();
                        break;
                    case 4:
                        //DoInterest();
                        break;
                    case 5:
                        DoHistory();
                        break;
                    case 6:
                        //RevertTransaction();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.Write("Enter valid input: ");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        #region Fields
        //-- Console declaration
        //private IConsole _console;

        //-- Used to simulate creating IDs for Transactions
        private int _transactionCount;

        //-- Declaring the Receiver
        private IAccount _account;

        //-- Declaring the Commands that will be used in the Invoker
        private ICommand _balance, _deposit, _withdraw, _revert;

        //-- Declaring the Invoker
        private AccountInvoker _invoker;

        #endregion

        public ProgramUI()
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            _transactionCount = 1;

            _account = new SavingsAccount
            {
                Balance = 500.00m,
                //InterestPercentage = 0.0215m
            };

            //_interest = new CalculateInterest(_account, _transactionCount);
            _balance = new GetBalanceCommand(_account, _transactionCount);
            _deposit = new DepositCommand(_account, 0m, _transactionCount);
            _withdraw = new WithdrawCommand(_account, 0m, _transactionCount);
            _revert = new RevertTransaction(_account, 0m, _transactionCount, 0);

            _invoker = new AccountInvoker(_balance, _deposit, _withdraw, _revert);
        }



        //-- Receiver
        SavingsAccount account = new SavingsAccount();


        #region Invoker Methods
        //-- Helper methods that allow us to break up the code that needs to fire to invoke a Concrete Command
        //-- Calls the Invoker method CheckBalance() that calls the ConcreteCommand CheckBalance
        public void DoBalance()
        {
            _balance = new GetBalanceCommand(_account, _transactionCount);
            _invoker.GetBalanceCommand = _balance;
            _invoker.GetBalance();
        }
        //-- Calls the Invoker method Withdraw() that calls the ConcreteCommand Withdraw
        public void DoWithdraw()
        {
            Console.Write("How much is being withdrawn?\n$");
            _withdraw = new WithdrawCommand(_account, GetValue(), _transactionCount);
            _invoker.WithdrawCommand = _withdraw;
            _invoker.Withdraw();
            _transactionCount = _invoker.TransactionHistory.Count + 1;
        }
        //-- Calls the Invoker method Deposit() that calls the ConcreteCommand Deposit
        public void DoDeposit()
        {
            Console.Write("How much is being deposited?\n$");
            _deposit = new DepositCommand(_account, GetValue(), _transactionCount);
            _invoker.DepositCommand = _deposit;
            _invoker.Deposit();
            _transactionCount = _invoker.TransactionHistory.Count + 1;
        }

        public void DoHistory()
        {
            Console.Clear();
            foreach (var transaction in _invoker.TransactionHistory)
                Console.WriteLine(transaction);
        }
        #endregion

        //-- Simple TryParse that loops until the user enters a valid input
        private decimal GetValue()
        {
            while (true)
                if (decimal.TryParse(Console.ReadLine(), out decimal output)) return output;
        }


    }
}
