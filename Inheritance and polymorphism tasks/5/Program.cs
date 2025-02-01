using System;

public class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

     public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack(GameCharacter target){}

    public bool IsAlive()
    {
        return Health > 0; 
    }
}

public class Warrior : GameCharacter
{
     public int Armor { get; set; }

    public Warrior(string name, int health, int armor) : base(name, health)
    {
        Armor = armor; 
    }
     public override void Attack(GameCharacter target)
    {
        int damage = 10; 
        int effectiveDamage = target is Warrior warriorTarget ? 
            Math.Max(0, damage - warriorTarget.Armor) : damage;

        target.Health -= effectiveDamage; // Уменьшаем здоровье цели
        Console.WriteLine($"{Name} атакует {target.Name} и наносит {effectiveDamage} урона!");
    }
    }

public class Mage : GameCharacter
{
     public int Mana { get; set; }

    public Mage(string name, int health, int mana) : base(name, health)
    {
        Mana = mana; 
    }

    public override void Attack(GameCharacter target)
    {
        if (Mana >= 5) 
        {
            int damage = 15; 
            target.Health -= damage; 
            Mana -= 5; 
            Console.WriteLine($"{Name} атакует {target.Name} магией и {damage} удар");
        }
        else
        {
            Console.WriteLine($"{Name} не хватает!"); 
        }
    }
}

public class Program
{
    public static void Main()
    {
         Warrior warrior = new Warrior("Полина", 100, 5); 
        Mage mage = new Mage("Алина", 80, 20); 

        Battle(warrior, mage);
    }

    public static void Battle(GameCharacter character1, GameCharacter character2)
    {
        while (character1.IsAlive() && character2.IsAlive())
        {
            character1.Attack(character2); 
            if (character2.IsAlive()) 
            {
                character2.Attack(character1); 
            }
        }

         if (character1.IsAlive())
        {
            Console.WriteLine($"{character1.Name} победила!"); 
        }
        else
        {
            Console.WriteLine($"{character2.Name} победила!"); 
        }
    }
}