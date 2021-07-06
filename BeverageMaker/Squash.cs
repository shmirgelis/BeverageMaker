using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    class Squash : IServeDrink
    {
        public string DrinkName { get; }

        public string DrinkSize { get; }

        public int DrinkServings { get; }
        private string SquashFlavour { get; }

        public Squash(string drinkName, string drinkSize, int drinkServings, string squashFlavour)
        {
            DrinkName = drinkName;
            DrinkSize = drinkSize;
            DrinkServings = drinkServings;
            SquashFlavour = squashFlavour;
        }

        public string DrinkHasBeenServed()
        {
            return $"Enjoy your {DrinkName} !!!";
        }

        public string MakingDrink()
        {
            return $"Pour {SquashFlavour} syrup --> mixing syrup with ice cold water ";
        }
    }
}
