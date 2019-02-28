using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    class MenuRepository
    {
        private Meal _meal;
        private List<Meal> _mealList;
        public List<Meal> MealList { get; private set; }

        public MenuRepository()
        {
            MealList = _mealList;
        }

        // This is good.  Put the others in here too
        public void AddMealToMenu(Meal meal)
        {
            MealList.Add(meal);
        }
    }
}
