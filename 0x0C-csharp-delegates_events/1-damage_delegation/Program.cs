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
