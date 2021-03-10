using System;
using System.Collections.Generic;

namespace ZadanieDomowe7
{
    public static class Loops
    {
        static public int Power(int num1, int num2)
        {
            int result = 1;
            if (num2 == 0)
            {
                result = 1;
            }
            else if (num1 == 0)
            {
                result = 0;
            }
            else
            {
                for (int i = 1; i <= num2; i++)
                {
                    result *= num1;
                }
            }

            return result;
        }

        static public List<int> RemainderOfDivisionOnNumber(int num1)
        {
            List<int> numbers = new List<int>();

            for (int i = num1; i < 10; i++)
            {
                if (i % num1 == 0)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        public static int СomparisonSquareOfNumberWithAnotherNumber(int num)
        {
            int count = 1;

            while (count * count < num)
            {
                count++;
            }

            return count-1;
        }

        static public int TheBiggestDivider(int num)
        {
            int k = 1;

            for (int i = num - 1; i > 0; i--)
            {
                if (num % i == 0)
                {
                    k = i;
                    return k;
                }
            }

            return k;
        }

        static public int SumNumberDivideBySeven(int num1, int num2)
        {
            int result = 0;
                for (int i = num1; i < num2; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            return result;
        }

        public static int Fibbonaci(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int fibbonaci = 0;

            if (num == 0 || num == 1 || num == -1)
            {
                return num;
            }

            for (int i = 1; i <= Math.Abs(num) - 1; i++)
            {
                fibbonaci = num1 + num2;
                num1 = num2;
                num2 = fibbonaci;
            }

            return Math.Sign(num) * fibbonaci;
        }
        static public int FindСommonDivisorByEvklid(int num1, int num2)
        {

            int temp = num1 % num2;

            while (temp != 0)
            {
                num1 = num2;
                num2 = temp;
                temp = num1 % num2;
            }

            return num2;
        }

        public static double CubeRootByBinaryMethod(int num1)
        {
            int left = 0;
            int num = Math.Abs(num1);
            int right = Math.Abs(num1);
            int mid = 0;


            if (num == 1)
            {
                return(Math.Sign(num1) * num);
            }

            while (true)
            {
                mid = left + (right - left) / 2;
                var cube = mid * mid * mid;
                if (cube == num)
                {
                    return (Math.Sign(num1) * mid);
                }
                else if (num < cube || mid > 1290)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }

                if (left == right)
                {
                    throw new ArgumentException();
                }
            }
        }

        public static int CountOddNumbers(int num)
        {
            int temp;
            int count = 0;

            while (num != 0)
            {
                temp = num > 10 ? num % 10 : num;
                if (temp % 2 != 0)
                {
                    count++;
                }
                num /= 10;
            }

            return count;
        }

        public static int ViewNumberInMirror(int num)
        {
            int result;
            int temp;
            string stNumber = null;

            while (num != 0)
            {
                temp = num % 10;
                stNumber += temp.ToString();
                num /= 10;
            }

            result = Convert.ToInt32(stNumber);

            return result;
        }

        public static List<int> CompareSumOddAndEvenNumbers(int num)
        {
            
            int temp = 0;
            List<int> numbers = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                int sumEven = 0;
                int sunOdd = 0;
                temp = i;

                while (temp != 0)
                {
                    int current = temp % 10;
                    if (current % 2 == 0)
                        sumEven += current;
                    else
                        sunOdd += current;
                    temp /= 10;
                }
                if (sumEven > sunOdd)
                    numbers.Add(i);
            }

            return numbers;
        }


        public static bool CompareDigitInNumbers(int num1, int num2)
        {
            int temp1 = num1;

            while (temp1 != 0)
            {
                int temp2 = num2;
                while (temp2 != 0)
                {
                    if (temp1 % 10 == temp2 % 10)
                    {
                        return true;
                    }
                        
                    temp2 /= 10;
                }
                temp1 /= 10;
            }

            return false;
        }
    }
}

