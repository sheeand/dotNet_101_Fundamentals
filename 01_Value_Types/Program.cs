using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType
        {
            Male, Female, Unknown
        }

        static void Main(string[] args)
        {
            //-- Declaration
            int myAge;

            //-- Initialization
            myAge = 42;

            //-- Integers
            int i = 100;
            //-- Other Integer Types
            byte by = 255;
            short sh = 32767;
            int iToo = 2147483647; // 2,147,483,647 +/-
            float PI = 3141592.65314598123412412f;
            Console.WriteLine(PI);
            double d = 780.01;
            decimal p = 7.80m; //TODO: Address benefit
            int? noValue = null;
            long youtubeMinutesWatched = 923424245925252525;
            Console.WriteLine(youtubeMinutesWatched);


            //-- Booleans
            bool isEarly = true;

            //-- Boolean Logic/Conditionals
            if (isEarly)
            {
                Console.WriteLine("Need more coffee.");
                Console.WriteLine("Yes indeed");
            }


            //-- Declare Enum
            var jenna = GenderType.Female;

            GenderType myGender = GenderType.Male;
            switch (myGender)
            {
                case GenderType.Male:
                    Console.WriteLine("Welcome Sir");
                    break;

                case GenderType.Female:
                    Console.WriteLine("Welcome Mam!");
                    break;

                case GenderType.Unknown:
                    Console.WriteLine("Howdy!");
                    break;
            }
        }
    }
}
