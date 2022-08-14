using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Abstraction
{
    public class AbstractDerived : AbstractSample
    {
        // Functions - Override Method
        public override void testAbstractMethod()
        {
            Console.WriteLine("testAbstractMethod");
        }
    }
}
