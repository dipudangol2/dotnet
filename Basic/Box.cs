using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Basic;
namespace Geoshape
{
    //Inheritance
    internal class Box : Shape
    {

        public Box(double length, double breadth, double height)
        {
            Console.WriteLine("Box constructed");
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
       
        public void PrintArea()
        {
            Console.WriteLine(this.CalculateArea());
        }
        //Function can be called directly with className without creating an object of the class 
        public static void PrintMe()
        {
            Console.WriteLine("printme");
        }
    }
}
