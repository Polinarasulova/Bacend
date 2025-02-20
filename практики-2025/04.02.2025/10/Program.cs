using System;
using System.Collections.Generic;

interface IFightable
{
    void Attack(Character target);
}

abstract class Character
{
    public string Name { get; set; }
    public int Health { get; protected set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} повержен!");
        }
        else
        {
            Console.WriteLine($"{Name} получил урон: {damage}. Осталось здоровья: {Health}.");
        }
    }
}

class Warrior : Character, IFightable
{
    public Warrior(string name, int health) : base(name, health) { }

    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} с мечом!");
        target.TakeDamage(50);
    }
}

class Mage : Character, IFightable
{
    public Mage(string name, int health) : base(name, health) { }

    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} заклинанием!");
        target.TakeDamage(30);
    }
}

class Inventory
{
    private List<string> _items = new List<string>();

    public void AddItem(string item)
    {
        _items.Add(item);
        Console.WriteLine($"{item} добавлен в инвентарь.");
    }

    public void DisplayItems()
    {
        Console.WriteLine("Содержимое инвентаря:");
        foreach (var item in _items)
        {
            Console.WriteLine("- " + item);
        }
    }
}

class Program
{
    static void Main()
    {
        var warrior = new Warrior("Воин", 100);
        var mage = new Mage("Маг", 80);

        warrior.Attack(mage);
        mage.Attack(warrior);

        var inventory = new Inventory();
        inventory.AddItem("Меч");
        inventory.AddItem("Зелье здоровья");
        inventory.DisplayItems();
    }
}