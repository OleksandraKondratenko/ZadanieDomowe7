using NUnit.Framework;
using System;
using System.Collections.Generic;
using ZadanieDomowe7;

namespace ZadanieDomowe7Tests
{
    public class VariablesHelperTests
    {
        [TestCase(3, 2, -19)]
        public void GetEquationValue_WhenEquationIsSolved_ShouldReturnAnswer(int num1, int num2, double expected)
        {
            double result = VariablesHelper1.GetEquationValue(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestCase(3,3)]

        public void GetEquationValue_WhenEquationIsNotSolved_ShouldReturnException(int num1, int num2)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHelper1.GetEquationValue(num1, num2));
        }

        [TestCase(3, 4, 4, 3)]
        [TestCase(8, 5, 5, 8)]
        public void Swap_WhenTestIsPassed_ShouldChangeNumbers(int num1, int num2, int expectedNum1, int expectedNum2)
        {
            VariablesHelper1.Swap(ref num1, ref num2);

            int actualNum1 = num1;
            int actualNum2 = num2;

            Assert.AreEqual(actualNum1, expectedNum1);
            Assert.AreEqual(actualNum2, expectedNum2);
        }

        [Test, TestCaseSource(nameof(DataDivideCases))]
        public void GetDivisionAndDivisionReminder_WhenTestIsPassed_ShouldBeCalculated(int num1, int num2, (int, int) expected)
        {
            (int, int) result = VariablesHelper1.GetDivisionAndDivisionReminder(num1, num2);
           
            Assert.AreEqual(expected, result);
        }

        static IEnumerable<object[]> DataDivideCases ()
        {
            yield return new object[] { 10, 3, (3, 1) };
        }

        [TestCase(5,0)]
        [TestCase(10,0)]

        public void GetDivisionAndDivisionReminder_WhenTestIsNotPassed_ShouldReturnException(int num1, int num2)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHelper1.GetDivisionAndDivisionReminder(num1,num2));
        }

        [TestCase(2,6,20,7)]
        public void GetLinearEquationValue_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2, int num3, double expected)
        {
            double result = VariablesHelper1.GetLinearEquationValue(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }
        
        [TestCase(0,5,6)]
         public void GetLinearEquationValue_WhenTestIsNotPassed_ShouldReturnException(int num1, int num2, int num3)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHelper1.GetLinearEquationValue(num1, num2, num3));
        }

        [TestCaseSource(nameof(DataForLineEquation))]
        public void WhenEquationOfTheLineIsPassed(int x1, int y1, int x2, int y2, (double, double)  expected)
        {
            (double, double) result = VariablesHelper1.GetEquationOfTheLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, result);
        }

        static IEnumerable< object[]> DataForLineEquation ()
        {
            yield return new object[] { 6, 12, 4, 2, (5.0, -18.0) };
        }
    }
}

