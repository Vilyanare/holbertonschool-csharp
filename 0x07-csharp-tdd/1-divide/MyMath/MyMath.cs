using System;

namespace MyMath
{
    /// <summary>
    /// Provides method to divide all integers in a matrix by given integer.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Returns given matrix with all integers divided by given integer.
        /// </summary>
        /// <param name="matrix">Matrix to divide.</param>
        /// <param name="num">Number to divide by.</param>
        /// <returns>Matrix with quotients or null if error</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
            {
                return null;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] / num;
                }
            }
            return matrix;
        }
    }
}
