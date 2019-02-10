using System;

/// <summary>
/// Delegate for altering health of player
/// </summary>
/// <param name="amount">How much to update the health</param>
public delegate void CaluclateHealth(float amount);

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
        System.Console.WriteLine($"{name} takes {damage} damage!");
        if (damage < 0)
            damage = 0;
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Adds health of player
    /// </summary>
    /// <param name="heal">How much health to add</param>
    public void HealDamage(float heal)
    {
        System.Console.WriteLine($"{name} heals {heal} HP!");
        if (heal < 0)
            heal = 0;
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
}
