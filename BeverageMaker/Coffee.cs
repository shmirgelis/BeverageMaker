using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    class Coffee : IServeDrink
    {
        public string DrinkName { get; }

        public string DrinkSize { get; }

        public int DrinkServings { get; }

        private int CoffeeStrength { get; }

        public Coffee(string drinkName, string drinkSize, int drinkServings, int coffeeStrength)
        {
            DrinkName = drinkName;
            DrinkSize = drinkSize;
            DrinkServings = drinkServings;
            CoffeeStrength = coffeeStrength;
        }
        public string DrinkHasBeenServed()
        {
            return $"Enjoy your {DrinkName} !!!";
        }

        public string MakingDrink()
        {
            return $"Boiling water --> Adding strength {CoffeeStrength} Coffee --> Stiring";
        }
    }
}

