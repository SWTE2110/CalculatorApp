using System;
using System.ComponentModel;
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
            uut.Clear();
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
        public void CalculatorTest_Divide_ByZeroError()
        {
            Assert.Throws<ArgumentException>(() => uut.Divide(7, 0));
            
        }

        [Test]
        public void CalculatorTest_Accumulator_Init()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(2,2)]
        [TestCase(0,0)]
        [TestCase(-2,-2)]
        [TestCase(1.5,1.5)]
        public void CalculatorTest_Accumulator_Add_Single(double a, double res)
        {
            uut.Add(a);
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }


        [TestCase(2,3,4,9)]
        [TestCase(0,-2,2,0)]
        [TestCase(-2.5,-3.6,7.9, 1.8)]
        public void CalculatorTest_Accumulator_Add_Multiple(double a, double b, double c, double res)
        {
            uut.Add(a);
            uut.Add(b);
            uut.Add(c);
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));

        }

        

}
}