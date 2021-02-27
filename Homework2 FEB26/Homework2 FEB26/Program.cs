using System;

namespace Homework2_FEB26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { 4, 5 };
            
        }
        static int[] GetArraysSum(int[] arr1,int[] arr2)
        {
            
            if (arr1.Length > arr2.Length)
            {
                int[] arraySum = new int[arr1.Length];
                int sum = 0;
                for(int i = 0;sum < arr1.Length; i++)
                {
                    if (i == arr2.Length)
                    {
                        i = 0;
                    }
                    arraySum[sum] = arr2[i];
                    
                    sum++;
                }
                for (int i = 0; i < arr1.Length; i++)
                {
                    arraySum[i] = arr1[i] + arraySum[i];
                }
                return arraySum;
            }
            else if (arr1.Length == arr2.Length)
            {
                int[] arraySum = new int[arr1.Length];
                for (int i = 0; i < arr1.Length; i++)
                {
                    arraySum[i] = arr1[i] + arr2[i];
                }
                return arraySum;
            }
            else
            {
                int[] arraySum = new int[arr2.Length];
                int sum = 0;
                for (int i = 0; sum < arr2.Length; i++)
                {
                    if (i == arr1.Length)
                    {
                        i = 0;
                    }
                    arraySum[sum] = arr1[i];

                    sum++;
                }
                for (int i = 0; i < arr1.Length; i++)
                {
                    arraySum[i] = arraySum[i] + arr2[i];
                }
                return arraySum;
            }

            
        }
    }
}
