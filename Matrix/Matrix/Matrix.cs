using System;

namespace Matrix
{
    public class Matrix
    {
        private double[,] _vals;

        public int NRow
        {
            get { return _vals.GetLength(1); }
        }
        public int NCol
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


    }
}
