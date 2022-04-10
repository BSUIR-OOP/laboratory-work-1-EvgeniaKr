using System;
using System.Drawing;
using ConsoleApp1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ListF>();
            var figure = new List<ListF>()
            {
            new Circle(50,50,10),
            new Ellips(50,50,20,40),
            new Line(10,10,60,60),
            new Polygon(40,40,40,80,80,80,80,40),
            new Reckv(40,40,40,80,80,80,80,40),
            new Rectangle(40,40,80,80),
           
            };

            foreach (var f in figure)
            {
                f.printf();
            }

            Console.ReadKey();

        }
    }
}
