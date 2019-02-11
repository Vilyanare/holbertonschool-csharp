using System;

/// <summary>
/// Delegate for altering health of player
/// </summary>
/// <param name="amount">How much to update the health</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Delegate for modifying base value of damage
/// </summary>
/// <param name="baseValue">Base value to modify</param>
/// <param name="modifier">How much to modify the base by</param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Enum that decides the modifier to the damage value
/// </summary>
public enum Modifier
{
    /// <summary>Half strength attack</summary>
    Weak,
    /// <summary>Normal attack</summary>
    Base,
    /// <summary>1.5 times stronger attack</summary>
    Strong
};

/// <summary>
/// Class containing the methods to interact with a player
/// </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Constructor for player class
    /// </summary>
    /// <param name="name">Name of the player. default 'Player'</param>
    /// <param name="maxHp">Max HP of the player. default 100</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Method that prints health of player.
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Removes health of player
    /// </summary>
    /// <param name="damage">How much health to remove</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        System.Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Adds health of player
    /// </summary>
    /// <param name="heal">How much health to add</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        System.Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates the new HP value and sets it accordingly
    /// </summary>
    /// <param name="newHp">Newly calculated hp value</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    /// <summary>
    /// Alters the damage by the modifier
    /// </summary>
    /// <param name="baseValue">Base value of the damage</param>
    /// <param name="modifier">Enum of the strength of the attack</param>
    /// <returns>Float of the modified value</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        return baseValue;
    }
}
