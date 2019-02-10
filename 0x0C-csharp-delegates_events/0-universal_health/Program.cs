using System;

class Player
{
    private string name;
    private float maxHP;
    private float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHP > 0)
            this.maxHP = maxHP;
        else
            this.maxHP = 100f;
        this.hp = this.maxHP;
    }

    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health.");
    }
}
