using System;
/// <summary>
/// Provides method IsOnlyASubclass.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks to see if derived type is a sublcass of base type.
    /// </summary>
    /// <param name="derivedType">subclass to check.</param>
    /// <param name="baseType">base type to check against.</param>
    /// <returns><c>true<c/> if is subclass; otherwise, <c>false<c/>.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.BaseType == baseType)
        {
            return true;
        }
        return false;
    }
}
