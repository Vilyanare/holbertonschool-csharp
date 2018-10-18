using System;
/// <summary>
/// Contains Add method
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two 2D or 3D matricies together.
    /// </summary>
    /// <param name="matrix1">2D array containing first matrix</param>
    /// <param name="matrix2">2D array containing second matrix</param>
    /// <returns>-1 if matricies aren't same size or valid vectors; otherwise new matrix with summed vectors</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int colLength = matrix1.GetLength(1);
        double [,] temp = new double [matrix1.GetLength(0), colLength];

        if (colLength > 1 && length < 4)
        {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.Length == matrix2.Length)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int k = 0; k < colLength; k++)
                    {
                        temp[i,k] = Math.Round(matrix1[i,k] + matrix2[i,k], 2);
                    }
                }
                return temp;
            }
        }
        return new double [,] {{-1}};
    }
}
