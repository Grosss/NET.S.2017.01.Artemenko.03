using System;
using Task2;

namespace Task2.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "xyaabbbccccdefww", b = "xxxxyyyyabklmopq";
            Console.WriteLine(StringHelper.ConcatAndSort(a, b));

            a = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(StringHelper.ConcatAndSort(a, a));

            Console.ReadLine();
        }
    }
}
