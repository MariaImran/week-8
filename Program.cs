using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week_8__problem_4_.bl;
using week_8__problem_4_.UI;

namespace week_8__problem_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = Rectangle__UI.rectangleInfo();
            shapes.Add(rectangle);
            Circle circle = Circle_UI.circleInfo();
            shapes.Add(circle);
            Square square = Square_UI.squareInfo();
            shapes.Add(square);

            Rectangle rectangle1 = Rectangle__UI.rectangleInfo();
            shapes.Add(rectangle1);
            Circle circle1 = Circle_UI.circleInfo();
            shapes.Add(circle1);


            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.tostring());
            }
            Console.ReadKey();

        }
    }
}
