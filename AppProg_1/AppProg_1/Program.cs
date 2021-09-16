using System;
using System.Collections.Generic;
using System.Text;

namespace AppProg_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите число:");
            bool test = true;
            int number = 0;
            string numberString = "";
            while (test)
            {
                try
                {
                    numberString = Console.ReadLine();
                    number = Convert.ToInt32(numberString);
                    test = false;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод, попробуйте сного ввести число!");
                    number = 0;
                }
            }
            Dictionary<char, string> converterFirstRank = new Dictionary<char, string>
            {
                { '0', "" },
                { '1', "один" },
                { '2', "два" },
                { '3', "три" },
                { '4', "четыре" },
                { '5', "пять" },
                { '6', "шесть" },
                { '7', "семь" },
                { '8', "восемь" },
                { '9', "девять" }
            };
            Dictionary<char, string> converterFirstRankExtra = new Dictionary<char, string>
            {
                { '0',"десять" },
                { '1', "одиннадцать" },
                { '2', "двенадцать" },
                { '3', "тринадцать" },
                { '4', "четырнадцать" },
                { '5', "пятнадцать" },
                { '6', "шестнадцать" },
                { '7', "семнадцать" },
                { '8', "восемнадцать" },
                { '9', "девятнадцать" },
            };
            Dictionary<char, string> converterSecondRank = new Dictionary<char, string>
            {
                { '0', "" },
                { '1', "десять" },
                { '2', "двадцать" },
                { '3', "тридцать" },
                { '4', "сорок" },
                { '5', "пятьдесят" },
                { '6', "шестьдесят" },
                { '7', "семьдесят" },
                { '8', "восемьдесят" },
                { '9', "девяносто" },
            };
            Dictionary<char, string> converterThirdRank = new Dictionary<char, string>
            {
                { '0', "" },
                { '1', "сто" },
                { '2', "двести" },
                { '3', "триста" },
                { '4', "четыреста" },
                { '5', "пятьсот" },
                { '6', "шестьсот" },
                { '7', "семьсот" },
                { '8', "восемьсот" },
                { '9', "девятьсот" },
            };
            Dictionary<char, string> converterFourthRank = new Dictionary<char, string>
            {
                { '1', "одна тысяча" },
                { '2', "две тысячи" },
                { '3', "три тысячи" },
                { '4', "четыре тысячи" },
                { '5', "пять тысяч" },
                { '6', "шесть тысяч" },
                { '7', "семь тысяч" },
                { '8', "восемь тысяч" },
                { '9', "девять тысяч" },
            };
            //% - остаток от деления
            // / - челочисленное деление
            for (var i = numberString.Length; i > 0; i--)
            {
                //Console.WriteLine("Текущее число: " + numberString[i - 1] + " : Текущая позиция: " + i);
                if ((i == (numberString.Length)))
                {
                    if (numberString.Length > 1 && numberString[i - 2].Equals('1'))
                    {
                        sb.Insert(0, converterFirstRankExtra[numberString[i - 1]] + " ");
                        i--;
                    }
                    else if (numberString.Equals("0"))
                    {
                        sb.Insert(0, "Ноль");
                    }
                    else
                    {
                        sb.Insert(0, converterFirstRank[numberString[i - 1]] + " ");
                    }
                }
                else if (i == (numberString.Length - 1))
                {
                    sb.Insert(0, converterSecondRank[numberString[i - 1]] + " ");
                }
                else if (i == (numberString.Length - 2))
                {
                    sb.Insert(0, converterThirdRank[numberString[i - 1]] + " ");
                }
                else if (i == (numberString.Length - 3))
                {
                    sb.Insert(0, converterFourthRank[numberString[i - 1]] + " ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
