using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMatrix
{
    class Matrix
    {
        private int[] body;
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }

        public int  matrixLength { get; set; }

        public Matrix(int row, int column, int[] array)
        {
            this.NumberOfColumns = column;
            this.NumberOfRows = row;
            this.matrixLength = row * column;
            this.body = array;
        }

        public void PrintMatrix()
        {
            int columns = NumberOfColumns;
            for(int i = 0; i < matrixLength; i++)
            {
                Console.Write(body[i] + " ");
                if(i + 1 == columns)
                {
                    Console.WriteLine();
                    columns += NumberOfColumns;
                }

            }
        }

        public Matrix Addition(Matrix matrix)
        {
            if (matrix.NumberOfColumns != this.NumberOfColumns || matrix.NumberOfRows != this.NumberOfRows)
                return null;

            Matrix sum = new Matrix(matrix.NumberOfRows, matrix.NumberOfColumns, new int[NumberOfColumns * NumberOfRows]);
            for(int i = 0; i < matrixLength; i++)
            {
                sum.body[i] = matrix.body[i] + this.body[i];
            }
            return sum;
        }
    }
}
