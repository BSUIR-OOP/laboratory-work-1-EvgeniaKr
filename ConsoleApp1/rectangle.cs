﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : Rhombus
    {
        public override int px3 { get { return x3; } }
        public override int px4 { get { return x4; } }
        public override int py3 { get { return y3; } }
        public override int py4 { get { return y4; } }
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }

        public override string name() { return "Rectangle"; }

        public override void printf()
        {
            Console.WriteLine(
                 $"{name()} ({this.x1},{this.y1}),({this.x2},{this.y2}),({this.x3},{this.y3}),({this.x4},{this.y4})");
        }
    }
}
