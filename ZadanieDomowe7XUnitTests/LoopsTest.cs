using Xunit;
using System;
using ZadanieDomowe7;
using System.Collections.Generic;

namespace ZadanieDomowe7XUnitTests
{
    public class LoopsTest
    {
        [Theory]
        [InlineData(8, 2, 64)]
        [InlineData(8, 0, 1)]
        [InlineData(0, 2, 0)]
        public void Power_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2, int expected)
        {
            int result = Loops.Power(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,  new int[]{2,4,6,8})]
        public void CountRemainderOfDivisionOnNumber_WhenTestIsPassed_ShouldBeCalculate(int num1,int[] expected)
        {
            int[] result = Loops.CountRemainderOfDivisionOnNumber(num1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(49, 6)]
        public void ComparisonSquareOfNumberWithAnotherNumber_WhenTestIsPassed_ShouldBeCalculate(int num1, int expected)
        {
            int result = Loops.СomparisonSquareOfNumberWithAnotherNumber(num1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(50, 25)]
        [InlineData(100, 50)]
        public void TheBiggestDivider_WhenTestIsPassed_ShouldBeCalculate(int num1, int expected)
        {
            int result = Loops.TheBiggestDivider(num1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 25, 42)]
        [InlineData(23,5, 0)]
        public void SumNumberDivideBySeven_WhenTestIsPassed_ShouldBeCalculate(int num1,int num2, int expected)
        {
            int result = Loops.SumNumberDivideBySeven(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5,5)]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        public void Fibbonaci_WhenTestIsPassed_ShouldBeCalculate(int num1, int expected)
        {
            int result = Loops.Fibbonaci(num1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 25, 1)]
        [InlineData(20, 30, 10)]
        public void FindСommonDivisorByEvklid_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2, int expected)
        {
            int result = Loops.FindСommonDivisorByEvklid(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(27, 3)]
        [InlineData(-27, -3)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        public void CubeRootByBinaryMethod_WhenTestIsPassed_ShouldBeCalculate(int num, int expected)
        {
            int result = Loops.CubeRootByBinaryMethod(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(28)]
        public void CubeRootByBinaryMethod_WhenTestIsNotPassed_ShouldReturnException(int num)
        {
            Assert.Throws<ArgumentException>(() => Loops.CubeRootByBinaryMethod(num));
        }

        [Theory]
        [InlineData(1283, 2)]
        [InlineData(13579, 5)]
        public void CountOddNumbers_WhenTestIsPassed_ShouldBeCalculate(int num, int expected)
        {
            int result = Loops.CountOddNumbers(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1283, 3821)]
        [InlineData(13579, 97531)]
        public void ViewNumberInMirror_WhenTestIsPassed_ShouldBeCalculate(int num, int expected)
        {
            int result = Loops.ViewNumberInMirror(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1283, 3821)]
        [InlineData(13579, 97531)]
        public void CompareSumOddAndEvenNumbers_WhenTestIsPassed_ShouldBeCalculate(int num, int expected)
        {
            int result = Loops.ViewNumberInMirror(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(DataForCompareSumOddAndEvenNumbers))]
        public void CompareSumOddAndEvenNumbers_WhenIsPassed_ShouldBeCalculate(int num, List<int> expected)
        {
            List<int> result = Loops.CompareSumOddAndEvenNumbers(num);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> DataForCompareSumOddAndEvenNumbers()
        {
            yield return new object[] { 10, new List<int>() { 2,4,6,8 } };
        }

        [Theory]
        [InlineData(389, 491)]
        [InlineData(145, 589)]
        public void CompareDigitInNumbers_WhenTestIsPassed_ShouldBeCalculate(int num1, int num2)
        {
            bool result = Loops.CompareDigitInNumbers(num1, num2);
            Assert.True(result);
        }
    }
}
