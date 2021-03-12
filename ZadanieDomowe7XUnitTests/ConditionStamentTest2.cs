using System;
using System.Collections.Generic;
using Xunit;
using ZadanieDomowe7;

namespace ZadanieDomowe7XUnitTests
{
    public class ConditionStamentTest2
    {
        [Theory]
        [InlineData(8, 7, 15)]
        [InlineData(8, 8, 64)]
        [InlineData(5, 8, -3)]
        public void CompareTwoNumbers_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2, int expected)
        {
            int result = ConditionStatement2.CompareTwoNumbers(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5,6,1)]
        [InlineData(-5,6,2)]
        [InlineData(-5,-6,3)]
        [InlineData(5,-6,4)]
        public void DefineQuarterOnTheAxisOfReferenceIsPassed_WhenTestIsPassed_ShouldFindPlacePoint(int x, int y, int expected)
        {
            int result = ConditionStatement2.DefineQuarterOnTheAxisOfReference(x, y);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 6, 1, 6,5,1)]
        [InlineData(-5, 6, 2,6,2,-5)]
        public void SortThreeNumberIncreasing_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2, int num3, int expectedNum1, int expectedNum2, int expectedNum3)
        {
            ConditionStatement2.SortNumbersByAscending(ref num1, ref num2, ref num3);
            Assert.Equal(expectedNum1, num1);
            Assert.Equal(expectedNum2, num2);
            Assert.Equal(expectedNum3, num3);
        }

        [Theory]
        [InlineData(3, -4, 1, new double[] { 0.33, 1 })]
        [InlineData(1, 4, 4, new double[] { -2.0 })]
        [InlineData(1, 6, 45, null)]
        public void QuadraticEquation_WhenIsPassed_ShouldBeCalculate(int a, int b, int c, double[] expected)
        {
            double[] result = ConditionStatement2.QuadraticEquation(a, b, c);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, "пятнадцать")]
        public void ConvertNumberToString_WhenNumberExist_ShouldPrintByAlphabet(int num, string expected)
        {
            string result = ConditionStatement2.ConvertNumberToString(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(9)]
        [InlineData(1025)]
        public void ConvertNumberToString_WhenNumberDoesntExist_ShouldReturn(int num)
        {
            Assert.Throws<ArgumentException>(() => ConditionStatement2.ConvertNumberToString(num));
        }
    }
}
