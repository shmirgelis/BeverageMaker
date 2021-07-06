using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    interface IServeDrink
    {
        string DrinkName { get; }
        string DrinkSize { get; }
        int DrinkServings { get; }

        string MakingDrink();
        string DrinkHasBeenServed();

    }
}
