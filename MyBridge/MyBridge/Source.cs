using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBridge
{
    public abstract class Source
    {

        public readonly IConstruction iSource;

        public Source(IConstruction _iSource)
        {
            iSource = _iSource;
        }
        public abstract void Display();
    }
}
