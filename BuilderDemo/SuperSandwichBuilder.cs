using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class SuperSandwichBuilder :SandwichBuilder
    {

        public override void PrepareBread()
        {
            throw new NotImplementedException();
        }

        public override void ApplyMeatAndCheese()
        {
            throw new NotImplementedException();
        }

        public override void ApplyVegetables()
        {
            throw new NotImplementedException();
        }

        public override void AddCondoments()
        {
            throw new NotImplementedException();
        }
    }
}
