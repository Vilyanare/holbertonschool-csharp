using System;
using System.Collections.Generic;
using System.Reflection;
/// <summary>
/// Provides Print method.
/// </summary>
class Info
{
    /// <summary>
    /// Prints properties and methods of given object.
    /// </summary>
    /// <param name="myObj">Object to print.</param>
    public static void Print(object myObj)
    {
        Type myType = myObj.GetType();
        Console.WriteLine("{0} Properties:", myType.Name);
        foreach (var property in myType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine("{0} Methods:", myType.Name);
        foreach (var method in myType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
