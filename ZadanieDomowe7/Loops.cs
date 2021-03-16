using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZadanieDomowe7
{
    public static class Loops
    {
        public static int Power(int num, int pofwer)
        {
            int result = 1;

            if (num != 0 && pofwer != 0)
            {
                for (int i = 1; i <= pofwer; i++)
                {
                    result *= num;
                }
            }
            else if (pofwer == 0)
            {
                result = 1;
            }
            else if (num == 0)
            {
                result = 0;
            }

            return result;
        }

        public static int[] CountRemainderOfDivisionOnNumber(int num)
        {
            int count = 0;

            for (int i = num; i < 10; i++)
            {
                if (i % num == 0)
                {
                    ++count;
                }
            }

            int[] numbers = new int[count];
            int j = 0;
            for (int i = num; i < 10; i++)
            {
                if (i % num == 0)
                {
                    numbers[j] = i;
                    ++j;
                }
            }


            return numbers;
        }

        public static int СomparisonSquareOfNumberWithAnotherNumber(int num)
        {
            int count = 0;

            for (int i = num / 2; i >= 1; i--)
            {
                if (i * i < num)
                {
                    count = i;
                    break;
                }
            }

            return count;
        }

        public static int GetBiggestDivider(int num)
        {
            int divider = 1;

            for (int i = num - 1; i > 0; i--)
            {
                if (num % i == 0)
                {
                    divider = i;
                    break;
                }
            }

            return divider;
        }

        public static int SumNumberDivideBySeven(int num1, int num2)
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
            int num1 = 1;
            int num2 = 1;
            int fibbonaci = 0;

            if (num == 0 || num == 1)
            {
                return num;
            }

            for (int i = 1; i <= num - 1; i++)
            {
                fibbonaci = num1 + num2;
                num1 = num2;
                num2 = fibbonaci;
            }

            return fibbonaci;
        }

        public static int FindСommonDivisorByEvklid(int num1, int num2)
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

        public static int GetCubeRootByBinaryMethod(int num)
        {
            int left = 0;
            int numAbs = Math.Abs(num);
            int right = Math.Abs(num);
            int mid = 0;
            int result = 0;

            if (numAbs == 1 || numAbs == 0)
            {
                result = (Math.Sign(num) * numAbs);
            }
            else
            {
                while (true)
                {
                    mid = left + (right - left) / 2;
                    var cube = mid * mid * mid;
                    if (cube == numAbs)
                    {
                        result = (Math.Sign(num) * mid);
                        break;
                    }
                    else if (numAbs < cube || mid > 1290)
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

            return result;
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
                    ++count;
                }

                num /= 10;
            }

            return count;
        }

        public static int ViewNumberInMirror(int num)
        {
            int result;
            int temp;
            StringBuilder stNumber = new StringBuilder();

            while (num != 0)
            {
                temp = num % 10;
                stNumber.Append(temp.ToString());
                num /= 10;
            }

            result = Convert.ToInt32(stNumber.ToString());

            return result;
        }

        public static IEnumerable<int> CompareSumOddAndEvenNumbers(int num)//IEnamereble
        {
            int temp = 0;
            List<int> numbers = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                temp = i;

                while (temp != 0)
                {
                    int current = temp % 10;
                    if (current % 2 == 0)
                    {
                        sum += current;
                    }
                    else
                    {
                        sum -= current;
                    }
                    temp /= 10;
                }
                if (sum > 0)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        public static bool CompareDigitInNumbers(int num1, int num2)//string
        {
            string stNum1 = num1.ToString();
            string stNum2 = num2.ToString();
            var result = stNum1.Intersect(stNum2);
            if (result == null)
            {
                return false;
            }

            return true;
        }
    }
}

