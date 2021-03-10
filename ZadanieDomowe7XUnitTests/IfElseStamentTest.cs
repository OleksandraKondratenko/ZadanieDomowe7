using System;
using System.Collections.Generic;
using Xunit;
using ZadanieDomowe7;

namespace ZadanieDomowe7XUnitTests
{
    public class IfElseStamentTest
    {
        [Theory]
        [InlineData(8, 7, 15)]
        [InlineData(8, 8, 64)]
        [InlineData(5, 8, -3)]
        public void TestCompareTwoNumbersIsPassed(int num1, int num2, int expected)
        {
            int result = IfElseStatement.CompareTwoNumbers(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5,6,1)]
        [InlineData(-5,6,2)]
        [InlineData(-5,-6,3)]
        [InlineData(5,-6,4)]
        public void TestDefineQuarterOnTheAxisOfReferenceIsPassed(int x, int y, int expected)
        {
            int result = IfElseStatement.DefineQuarterOnTheAxisOfReference(x, y);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData("DataExpectedArrays")]
        public void TestSortThreeNumberIncreasingIsPassed(int num1, int num2, int num3, int[] expected)
        {
            int[] resultArray = IfElseStatement.SortThreeNumberIncreasing(num1, num2, num3);
            Assert.Equal(expected, resultArray);
        }

        public static IEnumerable<object[]> DataExpectedArrays ()
        {
            yield return new object[]{ 2, 3, 4, new int[] {2,3,4}};
            yield return new object[]{ 3, 2, 4, new int[] {2,3,4}};
            yield return new object[]{ 4, 3, 2, new int[] {2,3,4}};
            yield return new object[]{ 2, 4, 2, new int[] {2,2,4}};
        }

        [Theory]
        [MemberData("ÑoefficientsQuadraticEquationAndExpectedResult")]
        public void WhenQuadraticEquationIsPassedTest(int a, int b, int c, List<double> expected)
        {
            List<double> result = IfElseStatement.QuadraticEquation(a, b, c);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> ÑoefficientsQuadraticEquationAndExpectedResult()
        {
            yield return new object[] { 3, -4, 1, new List<double>() {0.33,1}};
            yield return new object[] { 1, 4, 4, new List<double>() {-2.0}};
            yield return new object[] { 1, 6, 45, null };
            
        }

        [Theory]
        [InlineData(15, "ïÿòíàäöàòü")]
        public void TestConvertNumberToString(int num, string expected)
        {
            string result = IfElseStatement.ConvertNumberToString(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(9)]
        [InlineData(1025)]
        public void TestConvertNumberToStringGenerateException(int num)
        {
            Assert.Throws<ArgumentException>(() => IfElseStatement.ConvertNumberToString(num));
        }
    }
}
