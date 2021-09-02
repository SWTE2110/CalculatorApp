using NUnit.Framework;

namespace CalculatorApp.NUnit.Test
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            double a = 2;
            double b = 3;
        }

        [Test]
        public void Test1()
        {
            Calculator uut = new Calculator();
        }
    }
}