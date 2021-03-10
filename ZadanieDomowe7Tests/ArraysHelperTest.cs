using NUnit.Framework;
using System;
using ZadanieDomowe7;

namespace ZadanieDomowe7Tests
{
    public class ArraysHelperTest
    {
        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 1)]
        public void FindMinElementOfArray_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.FindMinElementOfArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 8)]
        public void FindMaxElementOfArray_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.FindMaxElementOfArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 2)]
        public void FindIndexMinElementOfArray_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.FindIndexMinElementOfArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 1)]
        public void FindIndexMaxElementOfArray_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.FindIndexMaxElementOfArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 11)]
        public void SumOfArrayEllementOddIndex_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.SumOfArrayEllementOddIndex(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, new int[] { 5, 3, 1, 8, 2 })]
        public void ReverseArray_WhenItPasssed(int[] array, int[] expected)
        {
            int[] result = ArraysHelper.ReverseArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, 3)]
        public void CountOddIndexOfArray_WhenItPasssed(int[] array, int expected)
        {
            int result = ArraysHelper.CountOddIndexOfArray(array);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, new int[] { 3, 5, 1, 2, 8 })]
        [TestCase(new int[] { 2, 8, 3, 5 }, new int[] { 3, 5, 2, 8 })]
        public void ReplaceFirstSecondPartOfNumber_WhenItPasssed(int[] array, int[] expected)
        {
            int[] result = ArraysHelper.ReplaceFirstSecondPartOfNumber(array);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, new int[] { 1, 2, 3, 5, 8 })]
        [TestCase(new int[] { 9, 3, 5, 7, 8, 6, 1, 4, 6 }, new int[] { 1, 3, 4, 5, 6, 6, 7, 8, 9 })]
        public void SelectSort_WhenTestPasssed(int[] array, int[] expected)
        {
            int[] result = ArraysHelper.SelectSort(array);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 8, 1, 3, 5 }, new int[] { 8, 5, 3, 2, 1 })]
        [TestCase(new int[] { 9, 3, 5, 7, 8, 6, 1, 4, 6 }, new int[] { 9, 8, 7, 6, 6, 5, 4, 3, 1 })]
        public void InsertSort_WhenTestPasssed(int[] array, int[] expected)
        {
            int[] result = ArraysHelper.InsertSort(array);
            CollectionAssert.AreEqual(expected,result);
        }
    }
}
