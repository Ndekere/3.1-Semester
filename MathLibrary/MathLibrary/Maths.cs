using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Maths
    {
        //constructor
       // public Maths()
       // {

       // }
        public double RectArea(double length, double width)
        {
            return length * width;
        }
            public double RectPer(double length, double width)
        {
                return 2 * (length + width);
            }
            public double CircleArea(double radius)
        {
                return 3.14 * radius * radius;
            }
            public double CirclePer(double radius)
        {
                return 2 * 3.14 * radius;
            }
        }
    }

