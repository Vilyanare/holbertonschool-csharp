using System;
/// <summary>
/// Contains Multiply method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Returns a new matrix with the product of two matrices.
    /// </summary>
    /// <param name="matrix1">First matrix to multiply</param>
    /// <param name="matrix2">Second matrix to multiply</param>
    /// <returns>-1 if can't multiply; otherwise matrix of product of matrix 1 and 2.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] temp = new double[matrix2.GetLength(0),matrix2.GetLength(1)];
        double tempNum;
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    tempNum = 0;
                    for (int k = 0; k < temp.GetLength(0); k++)
                    {
                        tempNum += matrix1[i,k] * matrix2[k,j];
                    }
                    temp[i,j] = Math.Round(tempNum, 2);
                }
            }
            return temp;
        }
        return new double[,] {{-1}};
    }
}
