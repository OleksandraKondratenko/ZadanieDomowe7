using System;

namespace ZadanieDomowe7
{
    public static class VariablesHelper2
    {
        public static double GetEquationValue(int num1, int num2)
        {
            if (num1 != num2)
            {
                return Math.Round((double)(5 * num1 + num2 * num2) / (double)(num2 - num1), 2);
            }

            throw new DivideByZeroException();
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static (int, int) GetDivisionAndDivisionReminder(int num1, int num2)
        {
            if (num2 != 0)
            {
                return (num1 / num2, num1 % num2);
            }

            throw new DivideByZeroException();
        }

        public static double GetLinearEquationValue(int num1, int num2, int num3)
        {
            if (num1 != 0)
            {
                return (double)(num3 - num2) / num1;
            }

            throw new DivideByZeroException();
        }

        public static (double, double) GetEquationOfTheLine(int x1, int y1, int x2, int y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }
    }
}

