using System;
/// <summary>
/// Contains DotProduct method.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Returns the dot product of two 2D or 3D vectors.
    /// </summary>
    /// <param name="vector1">double array containing first vector</param>
    /// <param name="vector2">double array containing second vector</param>
    /// <returns>-1 if not 2D or 3D vector; otherwise a <see cref="double"/> containing dot product.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double temp = 0;

        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            return -1;
        }

        for (int i = 0; i < vector1.Length; i++)
        {
            temp += vector1[i] * vector2[i];
        }
        return Math.Round(temp, 2);
    }
}
