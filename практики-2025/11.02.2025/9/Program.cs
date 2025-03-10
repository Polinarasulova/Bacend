using System;
using System.Collections.Generic;

class Calculator
{
    private Stack<int> operations = new Stack<int>();

    public void AddOperation(int result)
    {
        operations.Push(result);
        Console.WriteLine($"Операция добавлена. Текущий результат: {result}");
    }

      public void Undo()
    {
        if (operations.Count > 0)
        {
            int lastOperation = operations.Pop();
            Console.WriteLine($"отменена  {lastOperation}");

            if (operations.Count > 0)
            {
                Console.WriteLine($"Текущий результат: {operations.Peek()}");
            }
            else
            {
                Console.WriteLine(" нет предыдущих операций.");
            }
        }
        else
        {
            Console.WriteLine("----------------");
        }
    }

   
    public int GetCurrentResult()
    {
        return operations.Count > 0 ? operations.Peek() : 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

       calculator.AddOperation(10);
        calculator.AddOperation(20); 
        calculator.AddOperation(30); 

        Console.WriteLine($"Текущий результат: {calculator.GetCurrentResult()}");

        calculator.Undo(); ю
        calculator.Undo(); 

        Console.WriteLine($"Текущий результат: {calculator.GetCurrentResult()}");

        calculator.Undo(); 
        calculator.Undo(); 
    }
}