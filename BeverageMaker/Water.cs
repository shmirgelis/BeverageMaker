using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    class Water : IServeDrink
    {
        public string DrinkName { get; }

        public string DrinkSize { get; }

        public int DrinkServings { get; }

        bool _bottledWater;

        public Water(string drinkName, string drinkSize, int drinkServings, bool bottledWater)
        {
            DrinkName = drinkName;
            DrinkSize = drinkSize;
            DrinkServings = drinkServings;
           _bottledWater = bottledWater;
        }

        public string ServingDrink()
        {
            if (_bottledWater)
            {
                return $"Enjoy your overpriced {DrinkName} !!!";
            }
            else
            {
                return $"Here is your {DrinkName} cheapskate !!!";
            }
            
        }

        public string MakingDrink()
        {
            if (_bottledWater)
            {
                return $"Pour {DrinkName} from the bottle";
            }
            else
            {
                return $"Filling glass with {DrinkName} from the tap";
            }
            
        }
    }
}
