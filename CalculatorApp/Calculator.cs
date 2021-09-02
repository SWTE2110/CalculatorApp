using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class Calculator
    {
        public Calculator()
        {
            Clear();
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }
    

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {

            if (divisor == 0) throw new ArgumentException("Division med 0");
            else return dividend / divisor;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0) throw new ArgumentException("Division med 0");
            else
            {
                Accumulator = Accumulator / divisor;
                return Accumulator;
            }
        }

    }
}
