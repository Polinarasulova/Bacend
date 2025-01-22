using System;

public class BankAccount
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Внесено: {amount}. Текущий баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Сумма должна быть +.");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Снято: {amount}. Текущий баланс: {Balance}");
            return true;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Недостаточно средств для снятия");
            return false;
        }
        else
        {
            Console.WriteLine("Сумма должна быть +");
            return false;
        }
    }
}
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; private set; }

    public SavingsAccount(int accountNumber, double interestRate) : base(accountNumber)
    {
        InterestRate = interestRate;
    }

    public void AddInterest()
    {
        double interest = Balance * InterestRate / 100;
        Balance += interest;
        Console.WriteLine($"Добавлены проценты: {interest}. Новый баланс: {Balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount(12345, 5.0);

        savingsAccount.Deposit(150);
        savingsAccount.Withdraw(200);
        savingsAccount.AddInterest();
        Console.WriteLine($"Итоговый баланс: {savingsAccount.Balance}");
    }
}