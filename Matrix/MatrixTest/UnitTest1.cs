using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] m = new double[,] { { 1, 2, 0 }, { 3, -1, 1 }, { 2, 1, 1 } };
            double[] y = new double[] { 3, 0, 1 };

            var A = new Matrix.Matrix(m);
            var b = new Matrix.Vector(y);

            var solver = new Matrix.Solver(A, b);
            var actual = solver.Solve();
            double[] expected = new double[] { 1, 1, -2 };

            Assert.Equals(actual, expected);
        }
    }
}
