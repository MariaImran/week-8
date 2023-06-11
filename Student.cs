using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_2_.bl
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public string getProgram()
        {
            return program;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public double getFee()
        {
            return fee;
        }
        public override string toString()
        {
            return "Name : " + name + "\n" + "Address : " + address + "\n" + "Program : " + program + "\n" + "Year : " + year + "\n" + "Fee : " + fee + "\n";
        }
    }
}
