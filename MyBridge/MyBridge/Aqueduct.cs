using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public class Aqueduct : IConstruction
    {
        public string toDo(string key, string value)
        {
            return string.Format("==||==|Aqueduct|==||== {0} - {1} ", key, value);
        }
    }
}
