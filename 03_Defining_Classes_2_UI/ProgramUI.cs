using _03_Defining_Classes_2;
using System;

namespace _03_Definng_Classes_2_UI
{
    class ProgramUI
    {
        private WeatherRepository _weatherRepository;

        public void Run()
        {
            Console.WriteLine("What is the current temp?");
            var temp = Console.ReadLine();

            Console.WriteLine("What is the wind direction? \n");
            var direction = Console.ReadLine();

            Console.WriteLine("What is the wind speed? \n");
            var speed = Console.ReadLine();

            Console.WriteLine("Is it precipitating? y or n");
            var precipitation = Console.ReadLine();

            //TODO: Homework
            var weather = new Weather
            {
                WeatherDate = DateTimeOffset.Now
            };
        }
    }
}