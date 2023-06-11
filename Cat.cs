using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_3_.bl
{
    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
   
