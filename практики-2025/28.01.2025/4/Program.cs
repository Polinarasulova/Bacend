using System;

namespace BankExample
{
    public abstract class BankAccount
    {
        public double Balance { get; protected set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }
        public abstract void Withdraw(double amount);

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Пополнено на {amount} рублей. Текущий баланс: {Balance} рублей.");
        }
    }

     public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double initialBalance) : base(initialBalance) {}

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 100) 
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Текущий баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("снятие возможно только если на счету останется не менее 100");
            }
        }
    }

    public class CreditAccount : BankAccount
    {
        public CreditAccount(double initialBalance) : base(initialBalance) {}

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -500) 
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Текущий баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("можно уходить в минус до -500");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            BankAccount savingsAccount = new SavingsAccount(500);
            BankAccount creditAccount = new CreditAccount(-200);

            savingsAccount.Withdraw(300); 
            savingsAccount.Withdraw(200); 
       
            creditAccount.Withdraw(100); 
            creditAccount.Withdraw(300); 
        }
    }
}