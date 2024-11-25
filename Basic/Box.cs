using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoshape
{
    internal class Box
    {

        int length, breadth, height;
        public Box(int length, int breadth, int height)
        {
            Console.WriteLine("Box constructed");
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        private int CalculateArea()
        {
            return length * breadth;
        }
        public int PrintArea()
        {
            return CalculateArea();
        }
        //Function can be called directly with className without creating an object of the class 
        public static void PrintMe()
        {
            Console.WriteLine("printme");
        }
    }
}
