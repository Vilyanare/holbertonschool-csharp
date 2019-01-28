using System;
/*
Abstract base class
 */
abstract class Base
{
    public string name = null;

    /// <summary>
    /// Description of the class
    /// </summary>
    /// <returns>String with the name and type of class</returns>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}
