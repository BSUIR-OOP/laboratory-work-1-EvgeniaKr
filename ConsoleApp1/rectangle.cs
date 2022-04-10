using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : Reckv
    {

        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x1, y2, x2, y2, x2, y1)
        {

        }
       
        public override string name() { return "Rectangle"; }

        public override void printf()
        {
            Console.WriteLine(
                 $"{name()} ({this.x1},{this.y1}),({this.x2},{this.y2})");
        }
    }
}
