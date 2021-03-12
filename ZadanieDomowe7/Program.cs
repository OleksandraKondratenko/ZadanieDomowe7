using System;

namespace ZadanieDomowe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 1;

            ConditionStatement.SortNumbersByAscending(ref a, ref b, ref c);
            Console.WriteLine(Loops.CubeRootByBinaryMethod(27));

        }
    }
}
