using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace Basic
{
    internal class Sort
    {
        int[] arr;
        public Sort(int[] arr)
        {
            this.arr = arr;
        }
        private void PrintArray()
        {
            Console.Write("[ ");
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (i != this.arr.Length - 1)
                {
                    Console.Write($"{this.arr[i]}, ");

                }
                else
                {
                    Console.Write($"{this.arr[i]}");
                }
            }
            Console.WriteLine(" ]\n");

        }
        public void SelectSort()
        {
            Console.WriteLine("Choose the type of sort:\n1.Bubble Sort");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Before Sorting: ");
                    this.PrintArray();
                    this.BubbleSort();
                    Console.Write("After Sorting: ");
                    this.PrintArray();
                    break;
                case 6:
                    Console.Write("The Array is: ");
                    this.PrintArray();
                    break;
                default:
                    Console.WriteLine("Wrong choice!!");
                    break;
            }
        }
        private void BubbleSort()
        {
            for (int i = 0; i < this.arr.Length - 1; i++)
            {
                for (int j =0; j < arr.Length - i - 1; j++)
                {
                    if (this.arr[j] > this.arr[j + 1])
                    {
                        this.arr[j] = this.arr[j] + this.arr[j + 1];
                        this.arr[j + 1] = this.arr[j] - this.arr[j + 1];
                        this.arr[j] = this.arr[j] - this.arr[j + 1];
                    }
                }
            }
        }

    }
}
