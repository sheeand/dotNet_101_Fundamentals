using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{
    public class EmployeeRepository
    {
        private List<Employee> _employeeRepo;

        public EmployeeRepository()
        {
            _employeeRepo = new List<Employee>();
        }

        public void AddCustomerToList(Employee employee)
        {
            _employeeRepo.Add(employee);
        }

        public string EmailCustomer(Employee employee)
        {
            var message = "";

            if (employee.NumYearsEmployed > 1 && employee.NumYearsEmployed < 5)
                message = "Thanks for your service";
            else if (employee.NumYearsEmployed >= 5)
                message = "You are a phenomenol employee!";

            return message;
        }

    }
}
