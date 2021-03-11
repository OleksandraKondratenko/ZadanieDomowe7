﻿using System.Collections.Generic;
using Xunit;
using ZadanieDomowe7;

namespace ZadanieDomowe7XUnitTests
{
    public class TwoDimensionalArraysHelperTests
    {

        [Theory]
        [MemberData(nameof(DataFindMinElementOfArray))]
        public void FindMinElementOfArray_WhenIsPassed_ShouldBeCalculated(int [,] array, int expected)
        {
            int result =TwoDimensionalArraysHelper.FindMinElementOfArray(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataFindMinElementOfArray()
        {
            yield return new object[] { new int[,] { { 3,8,6}, {4,3,2 } },2 };
            yield return new object[] { new int[,] { { 50,40,-5}, {-30,0,3 } }, -30};
        }

        [Theory]
        [MemberData(nameof(DataFindMaxElementOfArray))]
        public void FindMaxElementOfArray_WhenIsPassed_ShouldBeCalculate(int[,] array, int expected)
        {
            int result = TwoDimensionalArraysHelper.FindMaxElementOfArray(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataFindMaxElementOfArray()
        {
            yield return new object[] { new int[,] { { 3, 8, 6 }, { 4, 3, 2 } }, 8 };
            yield return new object[] { new int[,] { { 50, 40, -5 }, { -30, 0, 3 } }, 50 };
        }

        [Theory]
        [MemberData(nameof(DataFindIndexMinElementOfArray))]
        public void FindIndexMinElementOfArray_WhenIsPassed_ShouldBeCalculate(int[,] array, (int,int) expected)
        {
            (int,int) result = TwoDimensionalArraysHelper.FindIndexMinElementOfArray(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataFindIndexMinElementOfArray()
        {
            yield return new object[] { new int[,] { { 3, 8, 6 }, { 4, 3, 2 } }, (1,2) };
            yield return new object[] { new int[,] { { 50, 40, -5 }, { -30, 0, 3 } }, (1,0) };
        }

        [Theory]
        [MemberData(nameof(DataFindIndexMaxElementOfArray))]
        public void FindMaxIndexElementOfArray_WhenIsPassed_ShouldBeCalculate(int[,] array, (int,int) expected)
        {
            (int,int) result = TwoDimensionalArraysHelper.FindIndexMaxElementOfArray(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataFindIndexMaxElementOfArray()
        {
            yield return new object[] { new int[,] { { 3, 8, 6 }, { 4, 3, 2 } }, (0,1) };
            yield return new object[] { new int[,] { { 50, 40, -5 }, { -30, 0, 3 } }, (0,0) };
        }

        [Theory]
        [MemberData(nameof(DataCompareWithNeithbours))]
        public void CompareWithNeithbours_WhenIsPassed_ShouldBeCalculate(int[,] array,  int expected)
        {
            int result = TwoDimensionalArraysHelper.CompareWithNeithbours(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataCompareWithNeithbours()
        {
            yield return new object[] { new int[,] { { 3, 8, 6 }, { 4, 3, 2 } }, 2};
            yield return new object[] { new int[,] { { 50, 40, -5 }, { -30, 0, 3 } }, 2 };
        }

        [Theory]
        [MemberData(nameof(DataMirrorViewOfArray))]
        public void MirrorViewOfArray_WhenIsPassed_ShouldBeNerOrder(int[,] array, int[,] expected)
        {
            int[,] result = TwoDimensionalArraysHelper.MirrorViewOfArray(array);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> DataMirrorViewOfArray()
        {
            yield return new object[] { new int[,] { { 3, 8, 6 }, { 4, 3, 2 } }, new int[,] { { 3,4},  { 8, 3 },  { 6, 2 } } };
            yield return new object[] { new int[,] { { 50, 40, -5 }, { -30, 0, 3 } }, new int[,] { { 50,-30 }, { 40, 0 }, { -5, 3 } } };
        }
    }
}
