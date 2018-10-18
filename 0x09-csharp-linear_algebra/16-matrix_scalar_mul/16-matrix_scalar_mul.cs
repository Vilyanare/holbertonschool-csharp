using System;
/// <summary>
/// Contains MultiplyScalar method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Returns the product of a 2D matrix containing 2D or 3D vectors and a scalar.
    /// </summary>
    /// <param name="matrix">2D array containing a matrix of 2D or 3D vectors.</param>
    /// <param name="scalar">number to multiply the vectors by.</param>
    /// <returns>-1 if invalid vectors; otherwise 2D matrix containing product of vectors and scalar.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int colLength = matrix.GetLength(1);
        double[,] temp = new double[matrix.GetLength(0),colLength];

        if (colLength > 1 && colLength < 4)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < colLength; k++)
                {
                    temp[i, k] = Math.Round(matrix[i ,k] * scalar, 2);
                }
            }
            return temp;
        }
        return new double[,] {{-1}};
    }
}
