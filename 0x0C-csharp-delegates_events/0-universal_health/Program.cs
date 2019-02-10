using System;

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
}
