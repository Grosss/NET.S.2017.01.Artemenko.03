using System;
using System.Linq;
using System.Text;

namespace Task2
{
    public static class StringHelper
    {
        public static string ConcatAndSort(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException();
            if (str1.Length == 0 && str2.Length == 0)
                throw new ArgumentException("Both strings are empty");
            char[] tempCharArray = (str1 + str2).ToArray<char>();
            Array.Sort(tempCharArray);
            StringBuilder resultString = new StringBuilder();
            resultString.Append(tempCharArray[0]);
            for (int i = 1; i < tempCharArray.Length; i++)
            {
                if (tempCharArray[i] != tempCharArray[i - 1])
                    resultString.Append(tempCharArray[i]);
            }
            return resultString.ToString();
        }
    }
}
