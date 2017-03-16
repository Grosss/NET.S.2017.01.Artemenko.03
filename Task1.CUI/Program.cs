using System;
using Task1;

namespace Task1.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 100, 50, -51, 1, 1 };
            int[] array2 = { 14, 21, -12, 32, -139, 67 };
            int result = ArrayTools.FindArrayCenter(array1);
            if (result == -1)
                Console.WriteLine("There is no such element in the array");
            else
                Console.WriteLine($"The index of the center element of array is {result}");

            result = ArrayTools.FindArrayCenter(array2);
            if (result == -1)
                Console.WriteLine("There is no such element in the array");
            else
                Console.WriteLine($"The index of the center element of array is {result}");

            Console.ReadLine();
        }
    }
}
