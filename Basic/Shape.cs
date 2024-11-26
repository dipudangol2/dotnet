using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Shape
    {
        protected double length, breadth, height;
        protected double CalculateArea()
        {
            return this.length * this.breadth;
        }
    }
}
