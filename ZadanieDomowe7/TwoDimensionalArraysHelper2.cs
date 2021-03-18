
namespace ZadanieDomowe7
{
    public static class TwoDimensionalArraysHelper2
    {
        public static int FindMinElementOfArray(int[,] array)
        {
            return array[FindIndexMinElementOfArray(array).Item1, FindIndexMinElementOfArray(array).Item2];
        }

        public static int FindMaxElementOfArray(int[,] array)
        {
            return array[FindIndexMaxElementOfArray(array).Item1, FindIndexMaxElementOfArray(array).Item2];
        }

        public static (int, int) FindIndexMinElementOfArray(int[,] array)
        {
            (int iMin, int jMin) result = (0, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[result.iMin, result.jMin] > array[i, j])
                    {
                        result = (i, j);
                    }
                }
            }

            return result;
        }

        public static (int, int) FindIndexMaxElementOfArray(int[,] array)
        {
            (int iMax, int jMax) result = (0, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[result.iMax, result.jMax] < array[i, j])
                    {
                        result = (i, j);

                    }
                }
            }

            return result;
        }

        public static int CompareWithNeithbours(int[,] array)
        {
            int count = 0;
            int length = array.GetLength(0)-1;
            int wide = array.GetLength(1) - 1;

            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= wide; j++)
                {
                    if ((i <= 0 || array[i, j] >= array[i - 1, j])
                        && (i >= length || array[i, j] >= array[i + 1, j])
                        && (j <= 0 || array[i, j] >= array[i, j - 1])
                        && (j >= wide || array[i, j] >= array[i, j + 1]))
                    {
                        ++count;
                    }
                }
            }

            return count;
        }

        public static int[,] GetMirrorViewOfArray(int[,] array)
        {
            var mirroredArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    mirroredArray[j, i] = array[i, j];
                }
            }

            return mirroredArray;
        }
    }
}
