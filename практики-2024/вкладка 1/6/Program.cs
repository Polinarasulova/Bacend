using System;

namespace Robots
{
     public abstract class Robot
    {
        public string Model { get; set; }

        public Robot(string model)
        {
            Model = model;
        }

        public abstract void PerformTask();
    }

    public class CleanerRobot : Robot
    {
        public CleanerRobot(string model) : base(model) {}

        public override void PerformTask()
        {
            Console.WriteLine($"{Model} убирает комнату");
        }
    }

       public class CookRobot : Robot
    {
        public CookRobot(string model) : base(model) {}

        public override void PerformTask()
        {
            Console.WriteLine($"{Model} готовит еду");
        }
    }

     public class GuardRobot : Robot
    {
        public GuardRobot(string model) : base(model) {}

        public override void PerformTask()
        {
            Console.WriteLine($"{Model} охраняет помещение");
        }
    }

    public class Program
    {
        public static void Main()
        {
             Robot cleanerRobot = new CleanerRobot("poli");
            Robot cookRobot = new CookRobot("poli2");
            Robot guardRobot = new GuardRobot("poli3");

            cleanerRobot.PerformTask();
            cookRobot.PerformTask();
            guardRobot.PerformTask();
        }
    }
}