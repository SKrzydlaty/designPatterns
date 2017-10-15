using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemoExtension
{
    public abstract class Manuscript
    {
        public readonly IFormatter formatter;

        public Manuscript(IFormatter _formatter)
        {
            formatter = _formatter;  
        }

        abstract public void Print();
    }
}
