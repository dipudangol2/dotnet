using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;

            Console.WriteLine("First:{0}, Second:{1}", firstNumber, secondNumber);
            Console.WriteLine("After Swap");
            //Swapping without temporary variable 
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("First: {0}, Second: {1}", firstNumber, secondNumber);
            int counter = 0;
            //print 3X3 squares of *
            for (counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("*    *    *");
            }
            Console.WriteLine("\n");

            for (counter = 0; counter < 3; counter++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
