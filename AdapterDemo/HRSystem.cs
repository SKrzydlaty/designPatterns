using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];
            employees[0] = new string[]{"1","Anna","Wanna","pracownikA"};
            employees[1] = new string[] { "2", "Barbara", "Liść", "pracownikB" };
            employees[2] = new string[] { "3", "Jonna", "Kwiat", "pracownikC" };
            employees[3] = new string[] { "4", "Ela", "Chmura", "pracownikD" };
            return employees;
        }
    }
}
