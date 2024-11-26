using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class SimpleInterest
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
}

