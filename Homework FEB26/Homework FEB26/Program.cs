using System;

namespace Homework_FEB26
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program obj = new Program();
            Console.WriteLine(obj.GetMatrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, 3).ToString());

        }
          int[,] GetMatrix(int[,] multiArray,int rankLength)
        {
            int rows = multiArray.GetUpperBound(0) + 1;
            int[,] lowerMatrix = new int[rankLength,rankLength];
            for(int i = 0;i < rankLength; i++)
            {
                
                for(int j = 0; j < rows; j++)
                {
                    if (i < j)
                    {
                        lowerMatrix[i, j] = 0;
                    }
                    else
                    {
                        lowerMatrix[i, j] = multiArray[i, j];
                    }
                }
            }
            return lowerMatrix;
        }   
    }
}
