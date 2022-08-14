using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.PolyProperties
{
    public class PolyPropertiesDerived : PolyProperties
    {
        // Functions
        public int bbb(int number1, int number2)
        {
            return number1 * number2;
        }

        // Functions - Override Method
        public override int aaa(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
