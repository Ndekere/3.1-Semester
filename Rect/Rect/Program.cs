using System;

namespace Rect {
    class Program {
        static void Main(String [] args) {
            Console.Write("Enter the Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());        
            // print area of rectangle to console ...
            Console.Write("The area is: " + length * width + Environment.NewLine);
            // print perimeter of rectangle to console ...
            Console.Write("The Perimeter is: " + 2 * (length + width) + "\r\n");
        }
 // NOTE:
 /*
  Use the Environment.NewLine command or "\r\n" to add spacing in the console output!
         */
    }

}