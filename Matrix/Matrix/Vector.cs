using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class Vector
    {
        private double[] _vals;

        public int Length
        {
            get { return _vals.GetLength(0); }
        }

        public double[] Val
        {
            get { return _vals; }
            private set { _vals = value; }
        }

        public Vector()
        {

        }

        public Vector(double[] raw)
        {
            Val = raw;
        }

        public double this[int index]
        {
            get
            {
                return _vals[index];
            }
        }
    }
}
