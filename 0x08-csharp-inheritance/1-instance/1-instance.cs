using System;
using System.Collections.Generic;
/// <summary>
/// Provides method IsInstanceOfArray.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if given object is an istance of Array class.
    /// </summary>
    /// <param name="obj">Object to check.</param>
    /// <returns><c>true</c> if object is of array class; otherwise, <c>false</c>.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}
