using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondoments()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = false;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "cucumber" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.meatType = Sandwich.MeatType.Salami;
            sandwich.cheeseType = Sandwich.CheeseType.Provolone;
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Sandwich.BreadType.White;
            sandwich.isToasted = false;
        }
    }
}
