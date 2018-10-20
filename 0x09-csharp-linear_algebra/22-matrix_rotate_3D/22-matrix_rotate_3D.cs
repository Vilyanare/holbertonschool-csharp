using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Rotate3D(double[,] matrix, char axis, double angle)
    {
        double cos = Math.Cos(angle), sin = Math.Sin(angle);
        double[,] flip = new double[3,3];
        double[,] rot = new double[,] { {1, 0, 0}, {0, 1, 0}, {0, 0, 1} };
        double[,] temp = new double[3,3];
        double tempNum;
        List<char> validAxis = new List<char>(new char[] {'x', 'y', 'z'});
        if (!validAxis.Contains(axis))
        {
            return new double[,] {{-1}};
        }

        if (axis == 'x') {
            rot[1,1] = cos;
            rot[1,2] = -sin;
            rot[2,1] = sin;
            rot[2,2] = cos;
        }
        else if(axis == 'y') {
            rot[0,0] = cos;
            rot[0,2] = -sin;
            rot[2,0] = sin;
            rot[2,2] = cos;
        }
        else {
            rot[0,0] = cos;
            rot[0,1] = -sin;
            rot[1,0] = sin;
            rot[1,1] = cos;
        }

        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    tempNum = 0;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        tempNum += rot[j,k] * matrix[k,i];
                    }
                    temp[j,i] = Math.Round(tempNum, 2);
                }
            }
            return temp;
        }
        return new double[,] {{0}};
    }
}
