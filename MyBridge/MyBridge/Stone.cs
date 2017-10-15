using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public class Stone : Source
    {
        public enum KindOfStone
        {
            GRANIT = 1,
            KWARCYT,
            BAZALT
        };

        private KindOfStone kindOfStone;

        public int KindS { get { return (int)kindOfStone; } set { kindOfStone = (KindOfStone)value; } }
        
        public Stone(IConstruction iSource)
            : base(iSource)
        {
            kindOfStone = KindOfStone.BAZALT;
        }

        public override void Display()
        {
            string value = Enum.GetName(typeof(KindOfStone), kindOfStone).ToString();
            Console.WriteLine(iSource.toDo("Kind of stone is:", value));
            Console.WriteLine();
        }
    }
}
