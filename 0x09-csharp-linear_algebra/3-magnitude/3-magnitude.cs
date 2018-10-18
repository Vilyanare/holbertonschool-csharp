using System;

/// <summary>
/// Contains magnitude method.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Returns magnitude of a 2d or 3d vector as a double to two points of precision.
    /// </summary>
    /// <param name="vector">array containing vecotr</param>
    /// <returns>-1 if not a vector; Otherwise returns a <see cref="double"/> of the magnitude.</returns>
    public static double Magnitude(double[] vector)
    {
        double temp = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        foreach (double num in vector)
        {
            temp += Math.Pow(num, 2);
        }
        return Math.Round(Math.Sqrt(temp), 2);
    }
}
