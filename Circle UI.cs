using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week_8__problem_4_.bl;

namespace week_8__problem_4_.UI
{
    class Circle_UI
    {
        public static Circle circleInfo()
        {
            Console.WriteLine("enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            return circle;
        }
    }
}
