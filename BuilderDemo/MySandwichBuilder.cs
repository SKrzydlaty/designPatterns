using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondoments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion", "Imbir" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.meatType = Sandwich.MeatType.Ham;
            sandwich.cheeseType = Sandwich.CheeseType.American;
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Sandwich.BreadType.Wheat;
            sandwich.isToasted = true;
        }
    }
}
