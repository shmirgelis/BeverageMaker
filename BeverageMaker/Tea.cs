using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    class Tea : IServeDrink
    {
        public string DrinkName { get; }

        public string DrinkSize { get; } = "Medium";

        public int DrinkServings { get; }

        public Tea(string drinkName, string drinkSize, int drinkServings)
        {
            DrinkName = drinkName;
            DrinkSize = drinkSize;
            DrinkServings = drinkServings;
        }

        public string DrinkHasBeenServed()
        {
            return $"Enjoy your {DrinkSize} {DrinkName} !!!";
        }

        public string MakingDrink()
        {
            return $"Boiling water --> Adding tea leafs --> Leaving to brew --> {BrewingTea()}";
        }

        private string BrewingTea()
        {
            return "Brewing --> Brewing --> Done";
        }
    }
}
