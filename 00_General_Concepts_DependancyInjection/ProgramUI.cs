using System;

namespace _00_General_Concepts_DependancyInjection
{
    public class ProgramUI
    {
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;  // this is the dependancy being injected into the controller
        }

        internal void Run()
        {
            _console.WriteLine("Hello");
            _console.ReadKey();
        }
    }
}