using System;

namespace Task1
{
    public static class ArrayTools
    {  
        public static int FindArrayCenter(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            int leftPartSum = 0, rightPartSum = 0;
            for(int i = 1; i < array.Length - 1; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    leftPartSum += array[j];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightPartSum += array[j];
                }
                if (leftPartSum == rightPartSum)
                    return i;
            }
            return -1;
        }
    }
}
