using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
     public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

         public void PrintContact()
        {
            Console.WriteLine($"Имя: {Name}, Телефон: {Phone}, Email: {Email}");
        }
    }
public class PhoneBook
    {
        private List<Contact> contacts;

        public PhoneBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine($"Контакт {contact.Name} добавлен.");
        }

        public Contact FindContactByName(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return contact;
                }
            }
            return null; 
        }

        public bool RemoveContact(string name)
        {
            var contact = FindContactByName(name);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine($"Контакт {name} удален.");
                return true;
            }
            Console.WriteLine($"Контакт {name} не найден.");
            return false;
        }

         public void ShowAllContacts()
        {
            Console.WriteLine("Список контактов:");
            foreach (var contact in contacts)
            {
                contact.PrintContact();
            }
        }
    }

      public class Program
    {
        public static void Main()
        {
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.AddContact(new Contact("Полина шерышова", "89821039758", "poli@example.com"));
            phoneBook.AddContact(new Contact("Мария шерышова", "89821039685", "maria@example.com"));
phoneBook.ShowAllContacts();

            var foundContact = phoneBook.FindContactByName("Полина шерышова");
            if (foundContact != null)
            {
                Console.WriteLine("Найден контакт:");
                foundContact.PrintContact();
            }

            phoneBook.RemoveContact("Мария шерышова");

            phoneBook.ShowAllContacts();
          }
    }
}
