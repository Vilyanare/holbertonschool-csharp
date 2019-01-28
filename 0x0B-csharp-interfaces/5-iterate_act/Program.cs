using System;
using System.Collections.Generic;
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

/// <summary>
/// Decoration class handles interaction with decoration objects.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;

    /// <summary>
    /// Constructor for Decoration class.
    /// </summary>
    /// <param name="name">Name of the decoration.</param>
    /// <param name="durability">Durability of the decoration.</param>
    /// <param name="isQuestItem">If the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.isQuestItem = isQuestItem;
        this.durability = durability;
        this.name = name;
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
            Console.WriteLine($"You hit the {name}. It cracks.");
        if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}

/// <summary>
/// Class describing and handling Keys.
/// </summary>
class Key : Base, ICollectable
{

    /// <summary>
    /// Constructor for key class.
    /// </summary>
    /// <param name="name">Name of the key.</param>
    /// <param name="isCollected">If it's been collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Getter/setter for iscollected.
    /// </summary>
    /// <value>Set isCollected to value.</value>
    public bool isCollected { get; set; }

    /// <summary>
    /// Method to pickup keys.
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>
/// Class that interacts with objects in room.
/// </summary>
class RoomObjects
{
    /// <summary>
    /// Iterates through a list of objects and uses their actions
    /// </summary>
    /// <param name="roomObjects">List of objects in room.</param>
    /// <param name="type">Type of object you want to interact with.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var item in roomObjects)
        {
            if (type.ToString() == "IInteractive")
            {
                if (item is IInteractive)
                {
                    IInteractive temp = item as IInteractive;
                    temp.Interact();
                }
            }
            if (type.ToString() == "IBreakable")
            {
                if (item is IBreakable)
                {
                    IBreakable temp = item as IBreakable;
                    temp.Break();
                }
            }
            if (type.ToString() == "ICollectable")
            {
                if (item is ICollectable)
                {
                    ICollectable temp = item as ICollectable;
                    temp.Collect();
                }
            }
        }
    }
}
