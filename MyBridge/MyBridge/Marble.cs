using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public class Marble : Source
    {
        public enum FromCountry
        {
            PL = 1,
            ENG,
            GM,
            CZE,
            SL,
            USA
        };

        private FromCountry fromCountry;

        public int FromC { get { return (int)fromCountry; } set { fromCountry = (FromCountry)value; } }
        public Marble(IConstruction iSource)
            : base(iSource)
        {
            fromCountry = FromCountry.PL;
        }

        public override void Display()
        {
            string value = Enum.GetName(typeof(FromCountry), fromCountry).ToString();
            Console.WriteLine(iSource.toDo("The marble is from:", value));
            Console.WriteLine();
        }
    }
}
