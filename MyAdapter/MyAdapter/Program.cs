using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapter adapter = new Adapter();
            Client client = new Client(adapter);
            client.ShowComponentsList();
            Console.ReadKey();
        }
    }
}
