using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    class Meal
    {
        // Field
        private string _name;
        private string _number;
        private string _description;
        private string _ingredientsList;

        // Properties
        public string Name { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string IngredientsList { get; set; }

        // Constructor
        public Meal()
        {
            Name = _name;
            Number = _number;
            Description = _description;
            IngredientsList = _ingredientsList;
        }

        // Methods
        //public void AddCustomerToList(Employee employee)
        //{
        //    _employeeRepo.Add(employee);
        //}

    }
}
