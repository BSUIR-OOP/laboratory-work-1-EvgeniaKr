using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ellips : ListF
    {
        private protected int FA, TA;
        private protected int x, y;

        public Ellips(int x1, int y1, int a1, int a2)
        {
          
            FA = a1;
            TA = a2;
            x = x1;
            y = y1;
        }


        public override string name() { return "Ellips"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} ({x},{y})({FA},{TA})");
        }
        
    }
}
