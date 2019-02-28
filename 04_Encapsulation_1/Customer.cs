using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
    public class Customer
    {
        //backing fields
        private string _firstName;
        private string _lastName;
        private int _age;

        // constructors

        public Customer()
        {
            
        }

        public Customer(string name, string lastName, int age, string question)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Question = question;
        }

        public string FirstName
        {
            get => _firstName; // a typed method that returns the value of a field
            //{
            //    return _firstName;
            //}
            set // a void method that assigns a value to a field
            {
                if (String.IsNullOrWhiteSpace(value))
                throw new Exception("First name cannot be empty");
                else
                _firstName = value.Trim();
            } 
            // 'value' represents the incoming value, which is an intrinsic generic
        }


        public string LastName
        {
            get => _lastName;

            set
            { 
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Last name cannot be empty");
                else
                    _lastName = value.Trim();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Enter a value greater than zero");
                _age = value;
            }
        }

        public string Question { get; set; }
    }
}
