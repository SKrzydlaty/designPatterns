using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget ITarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(ITarget);

            client.ShowEmployeeList();

            Console.ReadKey();
        }
    }
}
