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
        Console.WriteLine($"You try to open the {name}. It's locked");
    }
}

/// <summary>
/// Decoration class handles interaction with decoration objects.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;

    /// <summary>
    /// Constructor for Decoration class.
    /// </summary>
    /// <param name="Name">Name of the decoration.</param>
    /// <param name="Durability">Durability of the decoration.</param>
    /// <param name="IsQuestItem">If the decoration is a quest item.</param>
    public Decoration(string Name = "Decoration", int Durability = 1, bool IsQuestItem = false)
    {
        if (Durability < 1)
            throw new Exception("Durability must be greater than 0");
        isQuestItem = IsQuestItem;
        durability = Durability;
        name = Name;
    }

    /// <summary>
    /// Getter/setter for durability.
    /// </summary>
    /// <value>Int to set durability to.</value>
    public int durability { get; set; }

    /// <summary>
    /// Class to interact with the decoration.
    /// </summary>
    public void Interact()
    {
        if (durability < 1)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else
        {
            if (isQuestItem == true)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

    }

    /// <summary>
    /// Class to handle breaking of the decoration.
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks");
        if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess");
        if (durability < 0)
            Console.WriteLine($"The {name} is already broken");
    }
}
