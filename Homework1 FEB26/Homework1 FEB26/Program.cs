using System;

namespace Homework1_FEB26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3, 4, 5};
            int[] resultArray = GetArray(array, 5);
            for(int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
        }
        static int[] GetArray(int[] array, int position)
        {
            int[] resultArray = new int[array.Length - 1];
            for(int j = 0;j<resultArray.Length; j++)
            {
                resultArray[j] = array[j];
            }
            for (int i = position - 1; i < array.Length; i++)
            {
                if (i + 1 < array.Length)
                {
                    resultArray[i] = array[i + 1];
                }
               
            }
            return resultArray;
        }
    }
}
