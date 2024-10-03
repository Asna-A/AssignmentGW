using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths.Operations;

namespace Calculator_with_library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation arithmeticOperation = new ArithmeticOperation();
            double add=arithmeticOperation.Add(1, 2);
            Console.WriteLine("addition result=" + add);
            double sub=arithmeticOperation.Sub(2, 1);
            Console.WriteLine("substraction result=" + sub);
            RelationalOperation relationalOperation = new RelationalOperation();
            bool greaterthan=relationalOperation.GreatherThan(4, 5);
            Console.WriteLine("isgreater=" + greaterthan);
            bool equalto=relationalOperation.Equal(4, 5);
            Console.WriteLine("isequal=" + equalto);
            
        }
    }
}
