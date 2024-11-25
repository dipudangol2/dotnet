using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Geoshape; //importing Geoshape namespace
namespace Basic
{

    //class initialization
    class SimpleInterest
    {
        double principal, rate, time;

        public SimpleInterest(double principal, double rate, double time)
        {
            this.principal = principal;
            this.rate = rate;
            this.time = time;
        }
        private double CalculateInterest()
        {
            return this.principal * this.rate * this.time;
}
        public void PrintInterest()
        {
            Console.WriteLine($" The interest for Rs.{this.principal} for {this.time} years with rate {this.rate} per annum is {this.CalculateInterest()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest I = new SimpleInterest(150000, 5.9, 3);
            I.PrintInterest();
            
            Box box = new Box(5, 7, 9);
            Console.WriteLine(box.PrintArea());
            Box.PrintMe();
            
            Console.ReadLine();
        }
    }
}
