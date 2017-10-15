using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class ThirdPartyBillingSystem
    {
        private ITarget _target;
        public ThirdPartyBillingSystem(ITarget target)
        {
            _target = target;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = _target.GetEmployeeList();
            Console.WriteLine("******** Employee List ********");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
