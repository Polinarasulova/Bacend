using System;

namespace PracticeA
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Открытие нового счета
            var account1 = bank.OpenAccount("Азик Унитазик");
            var account2 = bank.OpenAccount("Полинка принцеска");

            // Депозит на счета
            account1.Deposit(1000);
            account2.Deposit(500);

            // Показать остатки
            Console.WriteLine($"Баланс счета {account1.AccountNumber}: {bank.CheckBalance(account1.AccountNumber)}");
            Console.WriteLine($"Баланс счета {account2.AccountNumber}: {bank.CheckBalance(account2.AccountNumber)}");

            // Перевод денег
            Console.WriteLine("Перевод 200 от принца Полине...");
            if (bank.Transfer(account1.AccountNumber, account2.AccountNumber, 200))
            {
                Console.WriteLine("успешно переведенно");
            }
            else
            {
                Console.WriteLine("не удалось");
            }

            // Показать выписку по счету
            bank.PrintStatement(account1.AccountNumber);
            bank.PrintStatement(account2.AccountNumber);

            // Запрос кредита
            Console.WriteLine("Запрос кредита на 150...");
            if (bank.RequestLoan(account1.AccountNumber, 150))
            {
                Console.WriteLine("одобрен");
            }
            else
            {
                Console.WriteLine("не одобрен");
            }

            // Показать остаток после кредита
            Console.WriteLine($"Баланс счета {account1.AccountNumber} после кредита: {bank.CheckBalance(account1.AccountNumber)}");

            // Изменение личных данных клиента
            bank.UpdateAccountHolderInfo(account1.AccountNumber, "Полина Вячеславовна ШЕРЫШОВА");
            bank.PrintStatement(account1.AccountNumber);
        }
    }
}