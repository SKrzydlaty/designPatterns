using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdapter
{
    public class Client
    {
        private IAdapter adapter = new Adapter();
        public Client(IAdapter _adapter)
        {
            adapter = _adapter;
        }

        public void ShowComponentsList()
        {
            List<string> componentsList = adapter.GetComponentsList();

            Console.WriteLine("********** list of laptop components **********");
            foreach(string item in componentsList)
            {
                Console.Write(item);
            }
        }
    }
}
