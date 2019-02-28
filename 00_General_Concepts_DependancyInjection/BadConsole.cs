using System;

namespace _00_General_Concepts_DependancyInjection
{
    internal class MockConsole : IConsole
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.WriteLine("This is a Mock console\n");
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Console.WriteLine("This is a Mock console\n");
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}