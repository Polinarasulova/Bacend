using System;

interface ITransaction
{
    void Transfer(decimal amount, BankAccount account);
}

abstract class BankAccount
{
    private decimal _balance;

    protected BankAccount(decimal balance) => _balance = balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public decimal GetBalance() => _balance;
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(decimal balance) : base(balance) { }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine("Нельзя снимать накопительного ");
    }
}

class CreditAccount : BankAccount, ITransaction
{
    public CreditAccount(decimal balance) : base(balance) { }

    public override void Withdraw(decimal amount)
    {
        if (_balance - amount < -1000)
        {
            Console.WriteLine("Превышен лимит.");
        }
        else
        {
            base.Withdraw(amount);
        }
    }

    public void Transfer(decimal amount, BankAccount account)
    {
        Withdraw(amount);
        account.Deposit(amount);
    }
}

class Program
{
    static void Main()
    {
        var savings = new SavingsAccount(1000);
        var credit = new CreditAccount(500);

        savings.Deposit(200);
        Console.WriteLine($"сберегательный: {savings.GetBalance()}");

        credit.Withdraw(800);
        Console.WriteLine($"кредитный: {credit.GetBalance()}");
    }
}