using System;
using Task3;

namespace Task3.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BitInsertion.PassNumbersAndBits(8, 15, 0, 0));
            Console.WriteLine(BitInsertion.PassNumbersAndBits(0, 15, 30, 30));
            Console.WriteLine(BitInsertion.PassNumbersAndBits(0, 15, 0, 30));
            Console.WriteLine(BitInsertion.PassNumbersAndBits(15, -15, 0, 4));
            Console.WriteLine(BitInsertion.PassNumbersAndBits(15, int.MaxValue, 3, 5));

            Console.ReadLine();
        }
    }
}
