using System;
using NUnit.Framework;

namespace CalculatorApp.Test.Unit
{
    public class CalculatorTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();
        }

        [Test]
        public void CalculatorTest_AddFunktion_ExpextFive()
        {
            //Act
            double a = 2;
            double b = 3;
            uut.Add(a, b);

            //Assert
            Assert.That(uut.Add(a, b), Is.EqualTo(5));
        }

        [Test]
        public void CalculatorTest_SubtractFunktion_ExpectNegativeOne()
        {
            //Act
            double a = 2;
            double b = 3;
            uut.Subtract(a, b);

            //Assert
            Assert.That(uut.Subtract(a, b), Is.EqualTo(-1));
        }

        [Test]
        public void CalculatorTest_MultiplyFunktion_ExpectSix()
        {
            //Act
            double a = 2;
            double b = 3;
            uut.Multiply(a, b);

            //Assert
            Assert.That(uut.Multiply(a, b), Is.EqualTo(6));
        }

        //Optional TestCase exercise used here
        [TestCase(2, 3, 8)]
        [TestCase(5, 3, 125)]
        [TestCase(3, 2, 9)]
        public void CalculatorTest_PowerFunktion_ExpectEight(double a, double b, double res)
        {
            //Act
            uut.Power(a, b);

            //Assert
            Assert.That(uut.Power(a, b), Is.EqualTo(res));
        }

        [TestCase(3, 2, 1.5)]
        [TestCase(10, -5, -2)]
        [TestCase(4, 2, 2)]
        [TestCase(4, 0.5, 8)]
        
        public void CalculatorTest_Divide(double a, double b, double res)
        {

            Assert.That(uut.Divide(a, b), Is.EqualTo(res));
        }

        [Test]
        public void CulculatorTest_Divide_ByZeroError()
        {
            Assert.Throws<ArgumentException>(() => uut.Divide(7, 0));
            
        }

}
}