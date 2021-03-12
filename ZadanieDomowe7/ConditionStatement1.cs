using System;
using System.Collections.Generic;

namespace ZadanieDomowe7
{
    public static class ConditionStatement
    {
        public static int CompareTwoNumbers(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = (num1 + num2);
            }
            else if (num1 == num2)
            {
                result = (num1 * num2);
            }
            else
            {
                result = (num1 - num2);
            }

            return result;
        }

        public static int DefineQuarterOnTheAxisOfReference(int x, int y)
        {
            int result;

            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static void SortNumbersByAscending(ref int a, ref int b, ref int c)
        {
            int temp;

            if (a < b && a < c)
            {
                temp = c;
                c = a;
                a = b > temp ? b : temp;
                b = b > temp ? temp : b;
            }
            else if (b < a && b < c)
            {
                temp = c;
                c = b;
                a = a > temp ? a : temp;
                b = a > temp ? temp : a;
            }
            else
            {
                temp = a;
                a = temp > b ? temp : b;
                b = temp > b ? b : temp;
            }
        }

        static public double[] QuadraticEquation(int a, int b, int c)
        {
            if (a != 0)
            {
                double[] result;
                double d = b * b - 4 * a * c;

                if (d > 0)
                {
                    double result1 = (-b - Math.Sqrt(d)) / (2 * a);
                    double result2 = (-b + Math.Sqrt(d)) / (2 * a);
                    result = new[] { Math.Round(result1, 2), Math.Round(result2, 2) };

                }
                else if (d == 0)
                {
                    double result0 = -b / (2 * a);
                    result = new double[] { Math.Round(result0, 2) };
                }
                else
                {
                    result = null;
                }

                return result;
            }

            throw new Exception("Квадратного уравнения не существует");
        }

        public static string ConvertNumberToString(int number)
        {
            string result;

            if (number < 100 && number >= 20)
            {
                int a = number / 10;
                int b = number % 10;

                if (b != 0)
                {
                    result = $"{Dozen(a)}{Units(b)}";
                }
                else
                {
                    result = Dozen(a);
                }
            }
            else if (number >= 10 && number < 20)
            {
                result = Teens(number);
            }
            else
            {
                throw new ArgumentException();
            }

            return result;
        }

        private static string Units(int num)
        {
            string units;

            switch (num)
            {
                case 1:
                    units = "один";
                    break;
                case 2:
                    units = "два";
                    break;
                case 3:
                    units = "три";
                    break;
                case 4:
                    units = "четыре";
                    break;
                case 5:
                    units = "пять";
                    break;
                case 6:
                    units = "шесть";
                    break;
                case 7:
                    units = "семь";
                    break;
                case 8:
                    units = "восемь";
                    break;
                case 9:
                    units = "девять";
                    break;
                default:
                    units = null;
                    break;
            }

            return units;
        }

        private static string Dozen(int num)
        {
            string dozen;

            switch (num)
            {
                case 1:
                    dozen = "десять";
                    break;
                case 2:
                    dozen = "двадцать";
                    break;
                case 3:
                    dozen = "тридцать";
                    break;
                case 4:
                    dozen = "сорок";
                    break;
                case 5:
                    dozen = "пятьдесят";
                    break;
                case 6:
                    dozen = "шестьдесят";
                    break;
                case 7:
                    dozen = "семьдесят";
                    break;
                case 8:
                    dozen = "восемьдесят";
                    break;
                case 9:
                    dozen = "девяносто";
                    break;
                default: throw new Exception("Некоректный ввод");
            }

            return dozen;
        }

        private static string Teens(int num)
        {
            string teen = null;
            switch (num)
            {
                case 11:
                    teen = "одинадцать";
                    break;
                case 12:
                    teen = "двенадцать";
                    break;
                case 13:
                    teen = "тринадцать";
                    break;
                case 14:
                    teen = "четырнадцать";
                    break;
                case 15:
                    teen = "пятнадцать";
                    break;
                case 16:
                    teen = "шестнадцать";
                    break;
                case 17:
                    teen = "семьнадцать";
                    break;
                case 18:
                    teen = "восемьнадцать";
                    break;
                case 19:
                    teen = "девятнадцать";
                    break;
                default: throw new ArgumentException("Некоректный ввод");
            }

            return teen;
        }
    }
}

