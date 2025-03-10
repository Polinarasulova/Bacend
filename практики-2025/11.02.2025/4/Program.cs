using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> tasks = new Queue<string>();

    static void Main(string[] args)
    {
        tasks.Enqueue("Задача 1");
        tasks.Enqueue("Задача 2");
        tasks.Enqueue("Задача 3");
        while (tasks.Count > 0)
        {
            ProcessTask();
        }
    }

    static void ProcessTask()
    {
        if (tasks.Count > 0)
        {
            string task = tasks.Dequeue(); 
            Console.WriteLine($"Обрабатывается: {task}");
        }
        else
        {
            Console.WriteLine("Нет задач");
        }
    }
}