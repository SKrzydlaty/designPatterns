using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public class Wood : Source
    {
        public enum GatunekDrewna
        {
            DĄB = 1,
            BUK,
            JESION,
            JODŁA,
            SOSNA,
            MODRZEW,
            ŚWIERK
        };

        private GatunekDrewna gatunek;

        public int GatunekD{ get { return (int)gatunek; } set { gatunek = (GatunekDrewna)value; } }
        
        public Wood(IConstruction iSource)
            : base(iSource)
        {
            gatunek = GatunekDrewna.DĄB;
        }

        public override void Display()
        {

            string value = Enum.GetName(typeof(GatunekDrewna), gatunek).ToString();
            Console.WriteLine(iSource.toDo("The name of wood is:",value));
            Console.WriteLine();
        }
    }
}
