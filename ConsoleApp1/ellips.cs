using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ellips : Figure
    {
        private protected int FA, TA;
        private protected int x, y;
        public virtual int F { get { return FA; } set { FA = value; } }
        public virtual int T { get { return TA; } set { TA = value; } }
        public int px { get { return x; } set { x = value; } }
        public int py { get { return y; } set { y = value; } }
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
