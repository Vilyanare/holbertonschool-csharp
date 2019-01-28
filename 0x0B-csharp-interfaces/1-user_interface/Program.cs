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
/// <summary>
/// Interface for Interactive class.
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Interface for Breakable class.
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Interface for Collectable class.
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Empty test class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Interact()
    {
        throw new NotImplementedException();
    }
    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Collect()
    {
        throw new NotImplementedException();
    }

}
