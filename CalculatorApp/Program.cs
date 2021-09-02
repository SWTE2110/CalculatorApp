using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            double a = 2;
            double b = 3;

            Console.WriteLine("Givet de to tal {0} og {1} kan vi se:", a, b);
            Console.WriteLine("Resultatet af " + a + " + " + b + " = {0}", cal.Add(a, b));
            Console.WriteLine("Resultatet af " + a + " - " + b + " = " + cal.Subtract(a, b));
            Console.WriteLine("Resultatet af " + a + " * " + b + " = " + cal.Multiply(a, b));
            Console.WriteLine("Resultatet af " + a + " ^ " + b + " = " + cal.Power(a, b));
            Console.Write("\n");

            if (cal.Add(a, b) == 5)
            {
                Console.WriteLine("Add-funktion virker som den skal!");
            }
            else
            {
                Console.WriteLine("Add-funktion virker IKKE som den skal!");
            }

            if (cal.Subtract(a, b) == -1)
            {
                Console.WriteLine("Subtract-funktion virker som den skal!");
            }
            else
            {
                Console.WriteLine("Subtract-funktion virker IKKE som den skal!");
            }

            if (cal.Multiply(a, b) == 6)
            {
                Console.WriteLine("Multiply-funktion virker som den skal!");
            }
            else
            {
                Console.WriteLine("Multiply-funktion virker IKKE som den skal!");
            }

            if (cal.Power(a, b) == 8)
            {
                Console.WriteLine("Power-funktion virker som den skal!");
            }
            else
            {
                Console.WriteLine("Power-funktion virker IKKE som den skal!");
            }
        }
    }
}
