using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondoments();
        }

        public Sandwich GetSandwitch()
        {
            return builder.GetSandwich();
        }
    }
}
