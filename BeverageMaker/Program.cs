using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace BeverageMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IServeDrink> drinksOrder = new List<IServeDrink>()
            {
                new Water("Water", "small", 1, false),
                new Squash("Squash", "large", 3, "strawberry"),
                new Tea("Tea", "extra large", 2),
                new Coffee("Coffee", "medium", 4, 2)
            };

            foreach (var drink in drinksOrder)
            {
                Console.WriteLine($"-----{drink.DrinkServings} of {drink.DrinkName}-----");
                Console.WriteLine("");
                for (int i = 0; i < drink.DrinkServings; i++)
                {                   
                    Console.WriteLine($"Ordering {drink.DrinkName}...");
                    Console.WriteLine(drink.MakingDrink());
                    Console.WriteLine(drink.ServingDrink());
                    Console.WriteLine();
                }
                
            }
           
        }
    }
}
