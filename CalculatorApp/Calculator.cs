using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class Calculator
    {
        public Calculator()
        {}

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divided by 0");
                return 0;
            }
        }

    }
}
