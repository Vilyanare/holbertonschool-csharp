using System;
/// <summary>
/// Contains Add method.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two 2D or 3D vectors together and returns the new vector.
    /// </summary>
    /// <param name="vector1">double array containing first vector</param>
    /// <param name="vector2">double array containing second vector</param>
    /// <returns>-1 if vectors are not vectors or the same size; otherwise a <see cref="double"/> array of the new vector.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] temp = new double[vector1.Length];
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            return new double[] {-1};
        }
        for (int i = 0; i < vector1.Length; i++)
        {
            temp[i] = Math.Round(vector1[i] + vector2[i],2 );
        }
        return temp;
    }
}
