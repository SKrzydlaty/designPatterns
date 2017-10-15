using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public class Castle : IConstruction
    {
        public string toDo(string key, string value)
        {
            return string.Format("/=\\_/=\\|Castle|/=\\_/=\\ {0} - {1}", key, value);
        }
    }
}
