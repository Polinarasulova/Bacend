using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       string text = "кот собака кот лиса собака кот";

         var words = text.Split(' ');

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }
foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}