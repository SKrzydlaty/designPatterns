using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Source> plans = new List<Source>();
            var construction1 = new Castle();
            var construction2 = new Aqueduct();
            var construction3 = new Bridge();

            var woodenCastle = new Wood(construction1);
            plans.Add(woodenCastle);

            var stoneAqueduct = new Stone(construction2);
            stoneAqueduct.KindS = 3;
            plans.Add(stoneAqueduct);

            var marbleBridge = new Marble(construction3);
            plans.Add(marbleBridge);

            foreach(var item in plans){
                item.Display();
            }

            Console.ReadKey();
        }
    }
}
