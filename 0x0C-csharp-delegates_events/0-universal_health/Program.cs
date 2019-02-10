using System;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp > 0 ? maxHp : 100f;
        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health.");
    }
}
