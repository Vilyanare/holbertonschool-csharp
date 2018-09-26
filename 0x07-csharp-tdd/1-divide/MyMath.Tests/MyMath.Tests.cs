using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMath_Tests
    {
        private StringWriter sw = new StringWriter();
        private TextWriter originalOutput = Console.Out;
        [Test]
        public void positiveDefault()
        {
            int [,] matrix = new int[,] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
            int [,] result = MyMath.Matrix.Divide(matrix, 2);
            int [,] end = new int [,] { {0, 1, 1,}, {2, 2, 3}, {3, 4, 4} };
            Assert.AreEqual(end, result);
        }
        [Test]
        public void ifDivIs0()
        {
            Console.SetOut(sw);
            int [,] matrix = new int[,] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
            int [,] result = MyMath.Matrix.Divide(matrix, 0);
            Assert.AreEqual("Num cannot be 0\n", sw.ToString());
            Console.SetOut(originalOutput);
        }
        [Test]
        public void isMatrixNull()
        {
            int [,] result = MyMath.Matrix.Divide(null, 2);
            Assert.AreEqual(null, result);
        }
    }
}
