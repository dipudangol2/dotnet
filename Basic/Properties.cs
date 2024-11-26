using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    //Access and modify private members using properties
    internal class Properties
    {
        int x;
        public int X
        {
            get;set;
            //get { return x; }
            //set { x = value; }
        }
    }
}
