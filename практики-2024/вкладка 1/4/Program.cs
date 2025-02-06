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
            Console.WriteLine($"Пополнено:  {amount}. Баланс: {Balance}.");
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
                Console.WriteLine($"Снято {amount} . Баланс: {Balance}.");
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
                Console.WriteLine($"Снято {amount}. Баланс: {Balance}.");
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

            Console.WriteLine("Операции со сберегательным счетом:");
            savingsAccount.Withdraw(300); 
            savingsAccount.Withdraw(200); 
           
            Console.WriteLine("\nОперации с кредитным счетом:");
            creditAccount.Withdraw(100); 
            creditAccount.Withdraw(300); 
        }
    }
}