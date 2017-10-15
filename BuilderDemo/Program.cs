using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Sandwich(
            //    Sandwich.BreadType.Wheat, false, 
            //    Sandwich.CheeseType.American, 
            //    Sandwich.MeatType.Ham, 
            //    true, 
            //    false, 
            //    new List<string> { "Tomato", "Onion", "Imbir" }
            //    ).Display();

            //var sandwich = new Sandwich();
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich1 = sandwichMaker.GetSandwitch();
            sandwich1.Display();

            Console.WriteLine("*****************************************");

            var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.BuildSandwich();
            var sandwich2 = sandwichMaker2.GetSandwitch();
            sandwich2.Display();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("hello");
            stringBuilder.Append("world");
            stringBuilder.ToString();

            Console.ReadKey();
        }
    }
}
