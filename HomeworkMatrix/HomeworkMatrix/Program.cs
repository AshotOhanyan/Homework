using System;

namespace HomeworkMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] array2 = new int[] { 1, 4, 7, 2, 5, 8, 3, 6, 9 };
            Matrix matrix1 = new Matrix(3, 3, array);
            Matrix matrix2 = new Matrix(3, 3, array2);
            Matrix sum = matrix1.Addition(matrix2);
            sum.PrintMatrix();
        }
    }
}
