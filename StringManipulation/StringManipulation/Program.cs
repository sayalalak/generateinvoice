﻿using System;
using System.Collections.Generic;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10982;

            string output = GenerateInvoice(counter);
            Console.WriteLine(output);
        }

        private static string GenerateInvoice(int count)
        {
            string month = DateTime.Now.ToString("MM");
            string year = DateTime.Now.ToString("yyyy");
            string day = DateTime.Now.ToString("dddd").Substring(0,2);
            string dayRom = ToRoman(DateTime.Now.Day);
            string yearRom = ToRoman(DateTime.Now.Year).Substring(2);


            return $"INV/{year}{month}/{day.ToUpper()}/{dayRom}/{yearRom}/{count + 1}";
        }

        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
