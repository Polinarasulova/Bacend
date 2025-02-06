using System;

public class Employee
{
     public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

     public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
}

public class Manager : Employee
{
     private Employee[] subordinates;
    private int subordinateCount; 
     public Manager(string name, string position, decimal salary, int maxSubordinates) : base(name, position, salary)
    {
        subordinates = new Employee[maxSubordinates]; 
        subordinateCount = 0; 
    }

     public void AddSubordinate(Employee employee)
    {
        if (subordinateCount < subordinates.Length)
        {
            subordinates[subordinateCount] = employee; 
            subordinateCount++;
            Console.WriteLine($"{employee.Name} Добавление подчинённых к менеджеру {Name}.");
        }
        else
        {
            Console.WriteLine($"Невозможно добавить {employee.Name}");
        }
    }

     public decimal CalculateTotalSalary()
    {
        decimal totalSalary = 0;

        for (int i = 0; i < subordinateCount; i++)
        {
            totalSalary += subordinates[i].Salary; 
        }

        return totalSalary;
    }

     public void ShowSubordinates()
    {
        Console.WriteLine($"Подчинённые {Name}:");
        for (int i = 0; i < subordinateCount; i++)
        {
            Console.WriteLine($"- {subordinates[i].Name}, Должность: {subordinates[i].Position}, Зарплата: {subordinates[i].Salary}");
        }
    }
}

public class Program
{
    public static void Main()
    {
         Manager manager = new Manager("Шерышовой Полины", "Руководитель отдела", 1000000, 5);

        // Создаем сотрудников
        Employee employee1 = new Employee("Вика Главатских", "Подчинённый", 50000);
        Employee employee2 = new Employee("Ксюша Иванова", "Подчинённый", 60000);
        Employee employee3 = new Employee("Мария Иванова", "Подчинённый", 55000);

         manager.AddSubordinate(employee1);
        manager.AddSubordinate(employee2);
        manager.AddSubordinate(employee3);

        manager.ShowSubordinates();

        decimal totalSalary = manager.CalculateTotalSalary();
        Console.WriteLine($"Подсчёта общего бюджета зарплат для подчинённых {totalSalary}");
    }
}
