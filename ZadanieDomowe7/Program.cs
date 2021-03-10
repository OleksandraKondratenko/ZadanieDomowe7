using System;

namespace ZadanieDomowe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 3, 8, 6 }, { 4, 3, 2 } };
        int[] array1 = new int[0];
            Console.WriteLine(TwoDimensionalArraysHelper.CompareWithNeithbours(array));

        }
    }
}
