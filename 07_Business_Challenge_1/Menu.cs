using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    class Menu
    {
        // Field
        private List<Meal> _menu;
        private MenuRepository _menuRepo = new MenuRepository();

        // Constructor
        public Menu()
        {
            _menu = new List<Meal>();
        }
    }
}
