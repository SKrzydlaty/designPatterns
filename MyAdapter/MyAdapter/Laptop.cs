using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdapter
{
    public class Laptop
    {
        public string[][] GetComponents()
        {
            string[][] components = new string[10][];
            components[0] = new string[] { "1", "procesor"};
            components[1] = new string[] { "2", "karta graficzna" };
            components[2] = new string[] { "3", "pamięć RAM" };
            components[3] = new string[] { "4", "dysk twardy" };
            components[4] = new string[] { "5", "akumulatpr" };
            components[5] = new string[] { "6", "karta dźwiękowa"};
            components[6] = new string[] { "7", "wyswietlacz" };
            components[7] = new string[] { "8", "naped optyczny" };
            components[8] = new string[] { "9", "klawiatura" };
            components[9] = new string[] { "10", "głośniki" };
            return components;
        }
    }
}
