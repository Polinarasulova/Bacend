using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> strings = new List<string>
        {
            "Апполинария",
            "Пилагея",
            "Полина",
            "Вика",
            "Азиз"
        };

         strings.Sort();

         Console.WriteLine(string.Join(", ", strings));
    }
}