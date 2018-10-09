using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class Employee
    {
        //-- Default Constructor
        public Employee() { }

        //-- Constructor Overload
        public Employee(int employeeId, string lastName, int age, int numYearsEmployed)
        {
            EmployeeID = employeeId;
            LastName = lastName;
            Age = age;
            NumYearsEmployed = numYearsEmployed;
        }

        //-- Properties
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumYearsEmployed { get; set; }
    }
}
