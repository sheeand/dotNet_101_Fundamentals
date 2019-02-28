using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_DependancyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgramUI program = new ProgramUI(new GoodConsole()); // this is injecting an instance of GoodConsole into ProgramUI
            //ProgramUI program = new ProgramUI(new BadConsole()); // this is injecting an instance of BadConsole into ProgramUI
            ProgramUI program = new ProgramUI(new UglyConsole()); // this is injecting an instance of BadConsole into ProgramUI

            program.Run();
        }
    }
}
