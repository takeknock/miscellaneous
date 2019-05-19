using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public interface ISolver
    {

        double[] Solve(Matrix x, Vector y);

    }
}
