using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 4, 3 };
            Sort s = new Sort(arr);
            s.SelectSort();
            Console.ReadLine();
        }
    }
}
