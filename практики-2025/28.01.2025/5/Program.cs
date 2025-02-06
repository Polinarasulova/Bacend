
using System;

namespace GameCharacters
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }

        public GameCharacter(string name)
        {
            Name = name;
        }

         public abstract void Attack();
    }

     public class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name) {}

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует мечом!");
        }
    }

     public class Mage : GameCharacter
    {
        public Mage(string name) : base(name) {}

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакует магией!");
        }
    }

     public class Archer : GameCharacter
    {
        public Archer(string name) : base(name) {}

        public override void Attack()
        {
            Console.WriteLine($"{Name} стреляет из лука!");
        }
    }

   public class Program
    {
        public static void Main()
        {
            GameCharacter[] characters = 
            {
                new Warrior("polin1"),
                new Mage("polin2"),
                new Archer("polin3")
            };

            foreach (GameCharacter character in characters)
            {
                character.Attack();
            }
        }
    }
}