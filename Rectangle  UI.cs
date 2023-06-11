using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week_8__problem_4_.bl;

namespace week_8__problem_4_.UI
{
    class Rectangle__UI
    {
        public static Rectangle rectangleInfo()
        {
            Console.WriteLine("Enter Width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            double height = double.Parse(Console.ReadLine());

            Rectangle Rectangle = new Rectangle(width, height);
            return Rectangle;
        }
    }
}
