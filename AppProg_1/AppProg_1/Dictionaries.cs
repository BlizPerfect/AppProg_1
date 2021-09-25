using System;
using System.Linq;
using System.Threading;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace AppProg_1
{
    class Dictionaries
    {
        public static readonly Dictionary<char, string> ConverterFirstRank = new Dictionary<char, string>
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
        public static readonly Dictionary<char, string> ConverterFirstRankExtra = new Dictionary<char, string>
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
        public static readonly Dictionary<char, string> ConverterSecondRank = new Dictionary<char, string>
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
        public static readonly Dictionary<char, string> ConverterThirdRank = new Dictionary<char, string>
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
        public static readonly Dictionary<char, string> ConverterFourthRank = new Dictionary<char, string>
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
    }
}
