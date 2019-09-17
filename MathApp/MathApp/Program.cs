using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();
            double l = 6, w = 5, r =7;
            Console.WriteLine("Rect Area =" + maths.RectArea(l, w));
            Console.WriteLine("Rect Per = " + maths.RectPer(l, w));
            Console.WriteLine("Circle Area = " + maths.CircleArea(r));
            Console.WriteLine("Circle Per = " + maths.CircleArea(r));
            //Console.WriteLine(Math.Log());
            //Console.WriteLine();
        }
    }
}
