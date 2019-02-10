using System;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

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

    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}



public delegate void CaluclateHealth(float amount);

public void TakeDamage(float damage)
{
    System.Console.WriteLine($"{name} takes damage!");
    if (damage < 0)
        damage = 0;
}
public void HealDamage(float heal)
{
    System.Console.WriteLine($"{name} heals {heal} HP!");
    if (heal < 0)
        heal = 0;
}
