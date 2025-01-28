using System;
using System.Collections.Generic;

namespace TaskManager
{
      public class Task
    {
        public string Title { get; set; }
        public bool IsCompleted { get; private set; }

        public Task(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public void CompleteTask()
        {
            IsCompleted = true;
        }
    }

    public class Project
    {
        private List<Task> tasks;

        public Project()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void ShowTasks()
        {
            Console.WriteLine("Все задачи:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"- {task.Title} (Завершена: {task.IsCompleted})");
            }
        }

        public void ShowCompletedTasks()
        {
            Console.WriteLine("Завершенные задачи:");
            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                {
                    Console.WriteLine($"- {task.Title}");
                }
            }
        }
    }

       public class Program
    {
        public static void Main()
        {
            Project project = new Project();

             Task task1 = new Task("Изучить C#");
            Task task2 = new Task("frontend");
            Task task3 = new Task("Пройти тест");

            project.AddTask(task1);
            project.AddTask(task2);
            project.AddTask(task3);

            task1.CompleteTask();

             project.ShowTasks();

            project.ShowCompletedTasks();
        }
    }
}