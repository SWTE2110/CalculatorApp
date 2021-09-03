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
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }
    

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            if ((exp % 1) != 0 && x < 0) throw new ArgumentException("Ingen imaginære tal");
            else
            {
                return Accumulator = Math.Pow(x, exp);
            }
        }

        public double Power(double exp)
        {
            if ((exp % 1) != 0 && Accumulator < 0) throw new ArgumentException("Ingen imaginære tal");
            else
            {
                Accumulator = Math.Pow(Accumulator, exp);
                return Accumulator;
            }
        }

        public double Divide(double dividend, double divisor)
        {

            if (divisor == 0) throw new ArgumentException("Division med 0");
            else return Accumulator =  dividend / divisor;
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
