using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_3_.bl
{
    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Woof");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
