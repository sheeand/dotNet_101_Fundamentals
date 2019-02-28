using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Student student = new Student();
            student.FirstName = "Ben";
            student.CurrentGrade = 'A';
            student.Greet();
            student.Greet("happy");

            Instructor instructor = new Instructor();
            instructor.FirstName = "Bill";
            instructor.Greet();


            Person person = new Student();
            person.FirstName = "John";

            people.Add(student);
            people.Add(person);

            foreach (var p in people)
            {
                Console.WriteLine($"{p.FirstName}");
            }

        }
    }
}
