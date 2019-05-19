using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MatrixTest
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void TestGaussianElimination()
        {
            double[,] m = new double[,] { { 1, 2, 0 }, { 3, -1, 1 }, { 2, 1, 1 } };
            double[] y = new double[] { 3, 0, 1 };

            var A = new Matrix.Matrix(m);
            var b = new Matrix.Vector(y);

            var solver = new Matrix.LinearEquationSolver();
            var actual = solver.Solve(A, b);
            double[] expected = new double[] { 1, 1, -2 };

            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
