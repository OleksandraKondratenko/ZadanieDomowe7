using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe7
{
    public static class IfElseStatement
    {
        #region Exercise1
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
        #endregion

        #region Exercise2
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
        #endregion

        #region Exercise3
        public static int[] SortThreeNumberIncreasing(int a, int b, int c)
        {
            int[] array = new int[3];

            if (a < b && a < c)
            {
                array[0] = a;
                array[1] = b < c ? b : c;
                array[2] = b < c ? c : b;
            }
            else if (b < a && b < c)
            {
                array[0] = b;
                array[1] = a < c ? a : c;
                array[2] = a < c ? c : a;
            }
            else
            {
                array[0] = c;
                array[1] = a < b ? a : b;
                array[2] = a < b ? b : a;
            }

            return array;
        }
        #endregion

        #region Exercise4
        static public List<double> QuadraticEquation(int a, int b, int c)
        {
            List<double> result = new List<double>();
            if (a == 0) { throw new Exception("Квадратного уравнения не существует"); }

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double result1 = (-b - Math.Sqrt(d)) / (2 * a);
                double result2 = (-b + Math.Sqrt(d)) / (2 * a);
                result.Add(Math.Round(result1,2));
                result.Add(Math.Round(result2,2));

            }
            else if (d == 0)
            {
                double result0 = -b / (2 * a);
                result.Add(Math.Round(result0,2));
            }
            else
            {
                result = null;
            }

            return result;
        }
        #endregion

        #region Exercise5
        static public string ConvertNumberToString(int number)
        {
            string result;

            if (number >= 100 || number < 10)
            {
                throw new ArgumentException();
            }
            else if (number>=10 && number < 20)
            {
                result = Teens(number);
            }
            else
            {
                int a = number / 10;
                int b = number % 10;

                if (b == 0)
                {
                    result = Dozen(a);
                }
                else
                {
                    result = $"{Dozen(a)}{Units(b)}";
                }
            }

            return result;
        }

        static string Units(int b)
        {
            string units;

            switch (b)
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

        static string Dozen(int a)
        {
            string dozen;

            switch (a)
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
        static string Teens(int num)
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
                default: throw new Exception("Некоректный ввод");
            }

            return teen;
        }
        #endregion
    }
}

