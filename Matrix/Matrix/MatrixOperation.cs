using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixOperation
    {
        static public Matrix Concatinate(Matrix x, Vector y)
        {
            int newColNum = x.ColNum + 1;
            int newRowNum = x.RowNum;
            int newLastIndex = x.ColNum;
            double[,] temp = new double[newRowNum, newColNum];

            for (int i = 0; i < newRowNum; i++)
            {
                for (int j = 0; j < x.ColNum; j++)
                {
                    temp[i, j] = x[i, j];
                }
            }
            for (int i = 0; i < newRowNum; i++)
            {
                temp[i, newLastIndex] = y[i];
            }

            return new Matrix(temp);
        }

    }
}
