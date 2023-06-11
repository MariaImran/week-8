using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week_8__problem_4_.bl;

namespace week_8__problem_4_.UI
{
    class Square_UI
    {
        public static Square squareInfo()
        {
            Console.WriteLine("Enter side:");
            double side = double.Parse(Console.ReadLine());
            Square square = new Square(side);
            return square;
        }
    }
}
