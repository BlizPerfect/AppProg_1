﻿using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AppProg_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            var numberString = InputeString();
            var resultInt = Convert.ToInt32(numberString);
            builder = ConvertFromDigitsToChars(numberString, builder);
            builder = AddRubles(resultInt, builder);
            var resultString = builder.ToString();
            resultString = Regex.Replace(resultString, "[ ]+", " ");
            resultString = char.ToUpper(resultString[0]) + resultString.Substring(1);
            Console.WriteLine("\nВы ввели: " + resultString);
        }

        public static string InputeString()
        {
            Console.WriteLine("Введите число, состоящее из максимум 4-ёх разрядов:");
            bool test = true;
            string result = "";
            while (test)
            {
                try
                {
                    result = Console.ReadLine();
                    if (result.Length > 4)
                    {
                        Console.WriteLine("Вы превысили допустимую разрядность!\nПопробуйте попробуйте сного ввести число!");
                    }
                    else if (result.StartsWith("0"))
                    {
                        Console.WriteLine("Неверный ввод, попробуйте сного ввести число!");
                    }
                    else
                    {
                        int number = Convert.ToInt32(result);
                        test = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуйте сного ввести число!");
                }
            }
            return result;
        }

        public static StringBuilder ConvertFromDigitsToChars(string numberString, StringBuilder builder)
        {
            for (var i = numberString.Length; i > 0; i--)
            {
                if ((i == (numberString.Length)))
                {
                    if (numberString.Length > 1 && numberString[i - 2].Equals('1'))
                    {
                        builder.Insert(0, Dictionaries.ConverterFirstRankExtra[numberString[i - 1]]);
                        i--;
                    }
                    else if (numberString.Equals("0"))
                    {
                        builder.Insert(0, "Ноль");
                    }
                    else
                    {
                        builder.Insert(0, Dictionaries.ConverterFirstRank[numberString[i - 1]]);
                    }
                }
                else if (i == (numberString.Length - 1))
                {
                    builder.Insert(0, Dictionaries.ConverterSecondRank[numberString[i - 1]] + " ");
                }
                else if (i == (numberString.Length - 2))
                {
                    builder.Insert(0, Dictionaries.ConverterThirdRank[numberString[i - 1]] + " ");
                }
                else if (i == (numberString.Length - 3))
                {
                    builder.Insert(0, Dictionaries.ConverterFourthRank[numberString[i - 1]] + " ");
                }
            }
            return builder;
        }

        public static StringBuilder AddRubles(int resultInt, StringBuilder builder)
        {
            if ((resultInt % 10 == 1) && (resultInt % 100 != 11))
            {
                return builder.Append(" рубль");
            }
            if ((resultInt % 10 >= 2) && (resultInt % 10 <= 4) && (resultInt % 100 < 10 || resultInt % 100 >= 20))
            {
                return builder.Append(" рубля");
            }
            return builder.Append(" рублей");
        }
    }
}
