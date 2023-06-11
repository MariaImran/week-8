using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week_8__problem_4_.UI;

namespace week_8__problem_4_.bl
{
    class Circle : Shape
    {
        private double radius;
        //parameterized constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // function 
        public override double area()
        {
            double area;
            area = 3.14 * radius * radius;
            return area;
        }
        // to string function
        public override string tostring()
        {
            return "The shape is Circle and its Area is " + area();
        }
    }
}
