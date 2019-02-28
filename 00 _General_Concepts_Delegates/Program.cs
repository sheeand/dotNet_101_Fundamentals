using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00__General_Concepts_Delegates
{
    class Program
    {
        // Delegate is a type that will have a method assigned to it
        // 
        //          Return type can only be void
        //               |
        //               | Object name
        //               |   |
        //     Keyword   |   |    Method param signature
        //        |      |   |         |
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            // Delegate is instantiated by the name of a method
            // having a compatible signature
            Del myDelegateMethod = DisplayTheMessage; // Notice that () is missing

            // The delegate object acts like an instance of the method
            // that was assigned to it, and takes the param(s) of that method 
            myDelegateMethod("Hello"); // Notice that it is camelCase

            //____________________________________________________________________


            // Func is a delegate under-the-hood that can also return something

            Console.WriteLine("What is your first name?");
            string FName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string LName = Console.ReadLine();

            //          Return type can only be void
            //               
            //                Object name               Method assignment
            //                     |                             |
            //    Method params    |     Delegate obj name       |
            //   /            \    |             |               |
            Func<string, string, string> fullNameDelegate = GetFullName;

            // The Func acts like an instance of the method
            // that was assigned to it, and takes the param(s) of that method 
            var fullName = fullNameDelegate(FName, LName);
            Console.WriteLine("Your name is " + fullName);
        }

        public static void DisplayTheMessage(string Message)
        {
            Console.WriteLine("The message is '" + Message + "'.");
        }

        public static string GetFullName(string FName, string LName)
        {
            string fullName = FName + " " + LName;
            return fullName;
        }
    }
}
