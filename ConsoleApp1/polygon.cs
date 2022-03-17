using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class polygon : circle
    {
        public virtual void Func()
        {

            Console.WriteLine("polygon(10, 10, 100, 100)");
        }
    }
}
