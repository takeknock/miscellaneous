using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class LinearEquationSolver : ISolver
    {


        public LinearEquationSolver()
        {

        }
        public double[] Solve(Matrix A, Vector b)
        {
            Matrix enlargedCoef = MatrixOperation.Concatinate(A, b);
            // forward elimination
            for (int i = 0; i < enlargedCoef.RowNum; i++)
            {
                double pivot = enlargedCoef[i, i];
                enlargedCoef[i, i] = 1.0;
                for (int j = i + 1; j < enlargedCoef.ColNum; j++)
                {
                    enlargedCoef[i, j] /= pivot;
                }

                for (int j = i + 1; j < enlargedCoef.RowNum; j++)
                {
                    double ratio = enlargedCoef[i, i];
                    for (int icol = 0; icol < enlargedCoef.ColNum; icol++)
                    {
                        enlargedCoef[j, icol] -= enlargedCoef[i, icol] * ratio;
                    }
                }
            }


            double[] ans = new double[enlargedCoef.RowNum];
            int lastIndex = enlargedCoef.RowNum - 1;
            // backward substitution
            for (int i = lastIndex; 0 <= i; i++)
            {
                int bIndex = enlargedCoef.ColNum - 1;
                ans[i] = enlargedCoef[i, bIndex];
            }


            return new double[] { 0, 0, 0 };
        }
    }
}
