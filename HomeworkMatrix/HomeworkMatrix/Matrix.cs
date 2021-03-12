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

        public int matrixLength { get; set; }

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
            for (int i = 0; i < matrixLength; i++)
            {
                Console.Write(body[i] + " ");
                if (i + 1 == columns)
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
            for (int i = 0; i < matrixLength; i++)
            {
                sum.body[i] = matrix.body[i] + this.body[i];
            }
            return sum;
        }

        public Matrix MatrixMult(Matrix matrix)
        {
            Matrix matrixMult = new Matrix(matrix.NumberOfRows, this.NumberOfColumns, new int[matrix.NumberOfRows * this.NumberOfColumns]);
            int matrixMultIndex = 0 + matrixMult.NumberOfColumns;
            for (int i = 0; i < matrixMult.body.Length; i++)
            {
                matrixMult.body[i] = matrix.body[i] * this.body[i];
                for (int j = 1; j < matrixMult.NumberOfColumns; j++)
                {
                    
                    if (j + 1 > matrixMult.NumberOfColumns)
                    {
                        continue;
                    }
                    else
                    {
                        matrixMult.body[i] = matrixMult.body[i] + matrix.body[j] * this.body[matrixMultIndex];
                        matrixMultIndex += matrixMultIndex;
                    }
                }
            }
        }
    }
}
