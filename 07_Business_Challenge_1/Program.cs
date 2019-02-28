using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
//    The Komodo Cafe is getting a new menu.

//The cafe manager at Komodo wants to be able to create a menu item, delete a menu item,
//and list all items on the cafe's menu. She needs a console app. 

//Each of their menu items will contain the following:
//a meal number so employees can say "I'll have the #5", 
//a meal name, 
//a description,
//a list of ingredients in the meal,
//and a price.

//Your task is to do the following:
//1. Create a Menu class with properties, constructors, and fields.
//2. Create a MenuRepository class that has methods needed.
//3. Create a Test Class for your repository methods. (You don't need to test
//your constructors or objects.Just the methods.)
//4. Create a Program file that allows the restaurant manager to add, delete, 
//and see all items in the menu list.

//Notes:
//We don't need to update the items right now.

    class Program
    {
        private static MenuRepository _menuRepo = new MenuRepository();
        private static Meal _meal = new Meal();

        
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do (enter number)? \n" +
                              "1 - Add a meal to the menu \n" +
                              "2 - Delete a meal from the menu \n" +
                              "3 - See all the meals in the menu");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Meal newMeal = new Meal();
                    //var mealRepo = _menuRepo;

                    Console.WriteLine("What will the name of the meal be?");
                    newMeal.Name = Console.ReadLine();

                    Console.WriteLine("What will the meal number be?");
                    newMeal.Name = Console.ReadLine();

                    Console.WriteLine("What is the description of the meal?");
                    newMeal.Name = Console.ReadLine();

                    Console.WriteLine("What will the ingredients be?");
                    newMeal.Name = Console.ReadLine();

                    _menuRepo.AddMealToMenu(newMeal);

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
            // add meal to menu list


            // delete meal to menu list

            // see all meal in the menu list.

        }
    }
}
