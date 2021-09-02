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

        public double Divide(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException) //Det virker ikke, den siger resultatet altid er 8, hvis vi dividerer med 0...
            {
                Console.WriteLine("Divided by 0");
                return 0;
            }
        }

    }
}
