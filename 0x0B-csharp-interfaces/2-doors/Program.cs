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
/// Class containing methods to interact with a door.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for door class.
    /// </summary>
    /// <param name="value">Name of the door.</param>
    public Door(string value = "Door")
    {
        name = value;
    }

    /// <summary>
    /// Interaction with a door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
