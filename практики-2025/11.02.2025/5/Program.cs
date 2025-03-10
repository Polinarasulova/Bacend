using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> pages = new Stack<string>();

    static void Main(string[] args)
    {
        pages.Push("Главная");
        pages.Push("Новости");
        pages.Push("Статья");
    }

       static void GoBack()
    {
        if (pages.Count > 1) 
        {
            pages.Pop(); 
            Console.WriteLine($"Текущая страница: {pages.Peek()}");
        else
        {
            Console.WriteLine("Вы на главной странице"); 
        }
    }
}