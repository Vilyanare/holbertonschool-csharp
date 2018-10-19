using System;
/// <summary>
/// Contains Rotate2D method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Returns a 2D matrix of the given matrix rotated.
    /// </summary>
    /// <param name="matrix">Matrix to be rotated.</param>
    /// <param name="angle">How far to rotate the matrix in radians.</param>
    /// <returns>-1 if not a square 2D matrix; otherwise rotated matrix.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double sin = Math.Sin(angle), cos = Math.Cos(angle);
        double[,] rot = new double[,] { {cos, -sin}, {sin, cos} };
        double[,] temp = new double[2,2];
        double tempNum;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    tempNum = 0;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        tempNum += rot[j,k] * matrix[i,k];
                    }
                    temp[i,j] = Math.Round(tempNum, 2);
                }
            }
            return temp;
        }
        return new double[,] {{-1}};
    }
}
