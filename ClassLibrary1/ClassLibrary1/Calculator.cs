using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Calculator
    {
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static double Substraction(double first, double second)
        {
            return first - second;
        }
        public static double Division(double first, double second)
        {
            if (second == 0) throw new DivideByZeroException();
            return first / second;
        }
        public static double Muliplication(double first, double second)
        {
            return first * second;
        }
    }
}
