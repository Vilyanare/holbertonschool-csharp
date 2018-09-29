using System;
using System.Collections.Generic;
/// <summary>
/// Provides Method IsOfTypeInt.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks to see if object is of type int.
    /// </summary>
    /// <param name="obj">Object to check type of.</param>
    /// <returns><c>true<c/> if is type int; otherwise, <c>false<c/>.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        return false;
    }
}
