using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Simple
    {
        // Class Members - Fields
        private string name;
        private int age;

        // GETs / SETs
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        // Constructors
        public Simple()
        {
            this.Name = "Unknown";
            this.Age = 0;
        }

        public Simple(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
