using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdapter
{
    public class Adapter : Laptop, IAdapter
    {
        public List<string> GetComponentsList()
        {
            string[][] components = GetComponents();
            List<string> componentsList = new List<string>();
            foreach(string[] item in components)
            {
                componentsList.Add(item[0] + ") ");
                componentsList.Add(item[1] + ".");
                componentsList.Add("\n");
            }
            return componentsList;
        }
    }
}
