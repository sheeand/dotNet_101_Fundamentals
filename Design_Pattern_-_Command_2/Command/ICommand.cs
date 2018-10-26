using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command
{
    public interface ICommand
    {
        bool ValidTransaction { get; set; }
        int TransactionID { get; set; }
        decimal TransactionValue { get; set; }
        bool Execute();
    }
}
