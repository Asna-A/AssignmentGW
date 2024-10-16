using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.Operations
{
    public class ArithmeticOperation
    {
        public double Add(double a, double b)
        {
            return a + b;

        }
        public double Sub(double a, double b)
        {
            return a - b;
        }

    }   
    public class RelationalOperation
    {
        public bool GreatherThan(double a, double b)
        {
            return a > b;
        }
        public bool Equal(double a, double b) 
        {
            return a == b; 
        }

    }


}
