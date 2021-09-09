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

        [TestCase(1,3,4)]
        [TestCase(-2, 2, 0)]
        [TestCase(1.5, 3.2, 4.7)]
        public void CalculatorTest_AddFunktion_ExpextFive(double a, double b, double res)
        {
            //Act
            
            uut.Add(a, b);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }

        [TestCase(2,1,1)]
        [TestCase(2, -4, 6)]
        [TestCase(10.5, 14.7, -4.2)]
        public void CalculatorTest_SubtractFunktion_ExpectNegativeOne(double a, double b, double res)
        {
            //Act
           
            uut.Subtract(a, b);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));
        }

        [TestCase(5,1,5)]
        [TestCase(5, -1, -5)]
        [TestCase(6, 0.3, 1.8)]
        [TestCase(0.1, 0.1, 0.01)]
        public void CalculatorTest_MultiplyFunktion_ExpectSix(double a, double b, double res)
        {
            //Act
            
            uut.Multiply(a, b);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));
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
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }

        [TestCase(3, 2, 1.5)]
        [TestCase(10, -5, -2)]
        [TestCase(4, 2, 2)]
        [TestCase(4, 0.5, 8)]
        
        public void CalculatorTest_Divide(double a, double b, double res)
        {
            uut.Divide(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }

        [Test]
        public void CalculatorTest_Divide_ByZeroError()
        {
            
            Assert.Throws<ArgumentException>(() => uut.Divide(7, 0));
            
        }

        [Test]
        public void CalculatorTest_Divide_ByZeroError_Alternative()
        {
            Assert.That(() => uut.Divide(7, 0), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void CalculatorTest_Accumulator_Init()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

      
        [Test]
        public void CalculatorTest_Accumulator_Clear()
        {
            uut.Add(10);

            Assert.That(uut.Accumulator, Is.EqualTo(10));
            uut.Clear();
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

        [TestCase(2, -2)]
        [TestCase(0, 0)]
        [TestCase(-2, 2)]
        [TestCase(1.5, -1.5)]
        public void CalculatorTest_Accumulator_Subtract_Single(double a, double res)
        {
            uut.Subtract(a);
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }


        [TestCase(2, 3, 4, -9)]
        [TestCase(0, -2, 2, 0)]
        [TestCase(-2.5, -3.6, 7.9, -1.8)]
        public void CalculatorTest_Accumulator_Subtract_Multiple(double a, double b, double c, double res)
        {
            uut.Subtract(a);
            uut.Subtract(b);
            uut.Subtract(c);
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));

        }
        [TestCase(5,10)]
        [TestCase(0,0)]
        [TestCase(-2,-4)]
        [TestCase(1.4,2.8)]
        public void CalculatorTest_Accumulator_Multiply_Single(double a, double res)
        {
            uut.Add(2);
            uut.Multiply(a);

            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }

        [TestCase(5, 2, -2, -40)]
        [TestCase(0, 2, 5, 0)]
        [TestCase(5.2, 8.1, 0.75, 63.18)]
        public void CalculatorTest_Accumulator_Multiply_Multiple(double a, double b, double c, double res)
        {
            uut.Add(2);
            uut.Multiply(a);
            uut.Multiply(b);
            uut.Multiply(c);

            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));
        }

        [TestCase(4, 2.5)]
        [TestCase(1, 10)]
        [TestCase(-2, -5)]
        [TestCase(2.5, 4)]
        public void CalculatorTest_Accumulator_Divide_Single(double a, double res)
        {
            uut.Add(10);
            uut.Divide(a);
            Assert.That(uut.Accumulator, Is.EqualTo(res));
        }

        [Test]
        public void CalculatorTest_Accumulator_Divide_Exception_Zero()
        {
            uut.Add(10);
           
            Assert.Throws<ArgumentException>(() => uut.Divide(0));
        }

        [TestCase(1, -1, 0.5, -20)]
        [TestCase(0.5,0.5,0.5,80)]
        [TestCase(10,10,10,0.01)]
        public void CalculatorTest_Accumulator_Divide_Multiple(double a, double b, double c, double res)
        {
            uut.Add(10);
            uut.Divide(a);
            uut.Divide(b);
            uut.Divide(c);
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));

        }

        [TestCase(0, 1)]
        [TestCase(-1, 0.5)]
        [TestCase(0.5, 1.41421356237)]
        public void CalculatorTest_Accumulator_Power_Single(double a, double res)
        {
            uut.Add(2);
            uut.Power(a);
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));
        }
        [TestCase(2,0.5,4,16)]
        public void CalculatorTest_Accumulator_Power_Multiple(double a, double b, double c, double res)
        {

            uut.Add(2);
            uut.Power(a);
            uut.Power(b);
            uut.Power(c);
            Assert.That(uut.Accumulator, Is.EqualTo(res).Within(0.000001));
        }

        [Test]
        public void CalculatorTest_Power_Imaginary()
        {
            Assert.Throws<ArgumentException>(() => uut.Power(-2, 1.5));
        }
    }

}