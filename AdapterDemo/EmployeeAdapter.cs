using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] item in employees)
            {
                employeeList.Add(item[0] + ",");
                employeeList.Add(item[1] + ",");
                employeeList.Add(item[2] + ",");
                employeeList.Add(item[3] + ",");
                employeeList.Add("\n");
            }
            return employeeList;
        }
    }
}
