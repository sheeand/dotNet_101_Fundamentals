using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command_2.Command
{
    interface ICommand
    {
        void Execute();

        decimal Execute(decimal amount); // overload
    }
}
