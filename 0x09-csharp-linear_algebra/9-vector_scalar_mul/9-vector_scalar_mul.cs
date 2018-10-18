using System;
/// <summary>
/// contains Multiply method
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a 2D or 3D vector by a scalar then returns new vector.
    /// </summary>
    /// <param name="vector">double array containing vector</param>
    /// <param name="scalar">double containing scalar</param>
    /// <returns>-1 if not a vector; otherwise <see cref="double"/> array containing new vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] temp = new double[vector.Length];
        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] {-1};
        }
        for (int i = 0; i < vector.Length; i++)
        {
            temp[i] = Math.Round(vector[i] * scalar, 2);
        }
        return temp;
    }
}
