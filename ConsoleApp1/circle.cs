using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Ellips
    {
        public int radius;

        public Circle(int x1, int y1, int r) : base(x1, y1, r, r)
        {
        }
        

        public override string name() { return "Circle"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} ({x},{y},{radius})");
        }
    }
}
