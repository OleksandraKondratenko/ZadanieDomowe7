﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe7
{
    public static class ArraysHelper
    {
        private static void ValidateArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("You are stupid");
            }
        }

        public static int FindMinElementOfArray(int[] array)
        {
            ValidateArray(array);
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int FindMaxElementOfArray(int[] array)
        {
            ValidateArray(array);
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int FindIndexMinElementOfArray(int[] array)
        {
            ValidateArray(array);
            int minIndex = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindIndexMaxElementOfArray(int[] array)
        {
            ValidateArray(array);
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int SumOfArrayEllementOddIndex(int[] array)
        {
            ValidateArray(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static int[] ReverseArray(int[] array)
        {
            ValidateArray(array);
            int temp = 0;
            int index;

            for (int i = 0; i < array.Length / 2; i++)
            {
                index = array.Length - i - 1;
                VariablesHelper.Swap( ref array[i], ref array[index]);
            }

            return array;
        }

        public static int CountOddIndexOfArray(int[] array)
        {
            ValidateArray(array);
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ReplaceFirstSecondPartOfNumber(int[] array)
        {
            ValidateArray(array);
            int index = 0;
            int temp = 0;

            if (array.Length % 2 == 0)
            {
                index = (array.Length) / 2;
            }
            else
            {
                index = (array.Length + 1) / 2;
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[index]);
                index++;
            }

            return array;
        }

        public static int[] SelectSort(int[] array)
        {
            ValidateArray(array);
            int temp;
            int current;
            int index;

            for (int i = 1; i < array.Length; i++)
            {
                current = array[i];
                index = i;
                while (index > 0 && array[index - 1] > current)
                {
                    temp = array[index - 1];
                    array[index - 1] = current;
                    array[index] = temp;
                    index--;
                }
            }

            return array;
        }

        public static int[] InsertSort(int[] array)
        {
            ValidateArray(array);
            int temp;
            int max;

            for (int i = 0; i < array.Length - 1; i++)
            {
                max = i;
                for (int index = i + 1; index < array.Length; index++)
                {
                    if (array[index] > array[max])
                    {
                        max = index;
                    }
                }
                temp = array[max];
                array[max] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
