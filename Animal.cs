using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_3_.bl
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            return "Animal : " + name;
        }
        public virtual void greets()
        {
            Console.WriteLine("Woof");
        }
    }
}
