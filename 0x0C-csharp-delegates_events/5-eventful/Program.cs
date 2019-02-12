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
    private string status;

    public EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
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
        OnCheckStatus(new CurrentHPArgs(hp));
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

    /// <summary>
    ///Method that prints a message based on how much health is left
    /// </summary>
    /// <param name="sender">Object that is calling this method</param>
    /// <param name="e">Arguments</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= maxHp / 2)
            status = $"{name} is doing well!";
        else if (e.currentHp >= maxHp / 4)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            status = $"{name} needs help!";
        else
            status= $"{name} is knocked out!";
        System.Console.WriteLine(status);
    }

    /// <summary>
    /// If HP is below a quarter of max hp then warns
    /// </summary>
    /// <param name="sender">Object calling this method</param>
    /// <param name="e">Arguments containing current hp</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            System.Console.WriteLine("Health has reached zero!");
        else
            System.Console.WriteLine("Health is low!");
    }

    /// <summary>
    /// Adds HPValueWarning method to HPCheck event if below 1/4 hp
    /// </summary>
    /// <param name="e">Arguments with current hp</param>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

/// <summary>
/// EventArgs class that holds currenthp
/// </summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    /// <summary>
    /// Assigns newHp to currentHp
    /// </summary>
    /// <param name="newHp">new hp value</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
