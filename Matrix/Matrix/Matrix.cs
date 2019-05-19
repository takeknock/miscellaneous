using System;

namespace Matrix
{
    public class Matrix
    {
        private double[,] _vals;

        public int RowNum
        {
            get { return _vals.GetLength(1); }
        }
        public int ColNum
        {
            get { return _vals.GetLength(0); }
        }

        public double[,] Val
        {
            get { return _vals; }
            private set { _vals = value; }
        }

        public Matrix()
        {

        }

        public Matrix(double[,] raw)
        {
            Val = raw;
        }


        public double this[int row, int col]
        {
            get
            {
                return _vals[row, col];
            }
            set
            {
                _vals[row, col] = value;
            }
        }

    }
}
