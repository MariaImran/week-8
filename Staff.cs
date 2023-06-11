using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_2_.bl
{
    class Staff : Person
    {
        private string school;
        private double pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }
        public string getSchool()
        {
            return school;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public double getPay()
        {
            return pay;
        }
        public override string toString()
        {
            return "Name : " + name + "\n" + "Address : " + address + "\n" + "School : " + school + "\n" + "Pay : " + pay + "\n";
        }

    }
}
