using System;

namespace AnimaApol
{
    public class Animal
    {
        private string name;
        private int age;

       public Animal(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

         public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {GetName()}, Возраст: {GetAge()}");
        }
    }

     public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

               public void Bark()
        {
            Console.WriteLine("Гавь!");
        }

        public new void PrintInfo()
        {
            Console.WriteLine($"Имя: {GetName()}, Возраст: {GetAge()}, Порода: {Breed}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Вика", 15, "такса");
            
            myDog.PrintInfo();
            
            myDog.Bark();
        }
    }
}