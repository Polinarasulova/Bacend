using System;

namespace BankA
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal balance; 

        public BankAccount(string accountNumber) 
        {
            AccountNumber = accountNumber; 
            balance = 0; 
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                 balance += amount; 
                Console.WriteLine($"баланс после пополнения: {GetBalance():C}"); 
           
            }
            else
            {
                Console.WriteLine("сумма должна быть полож.");
            
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance) 
            {
                balance -= amount; 
                Console.WriteLine($"баланс после снятия: {GetBalance():C}"); 
            }
            else
            {
                Console.WriteLine("недостаточно средств");
            
            }
        }

        public decimal GetBalance() 
        {
            return balance; 
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            BankAccount account = new BankAccount("156");

            account.Deposit(10000);
             account.Withdraw(500);
            account.Deposit(-200); 

            Console.WriteLine($"Текущий баланс: {account.GetBalance():C}"); 
        
        }
    
    }


}
