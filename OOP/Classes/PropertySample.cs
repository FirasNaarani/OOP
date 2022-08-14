using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class PropertySample
    {
        // Class Members - Fields
        public string Text { get; set; }
        public int Number { get; set; }

        // Functions
        public void Func1()
        {
            Console.WriteLine(Text + " " + Number);
        }
    }
}
