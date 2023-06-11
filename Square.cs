using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_8__problem_4_.bl
{
    class Square : Shape
    {
        private double Side;
        // parameterized constructor
        public Square(double side)
        {
            this.Side = side;
        }
        // function 
        public override double area()
        {
            double area = Side * Side;
            return area;
        }
        public override string tostring()
        {
            return "The shape is Square and its Area is " + area();
        }

    }
}
