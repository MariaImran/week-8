using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_2_.bl
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }
        public  virtual string toString()
        {
            return "Name : " + name + "\n" + "Address : " + address;
        }

    }
}
