using System;
using NLog;

namespace NlogAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System" );
            AddressBook addressBook = new AddressBook();
            addressBook.AddDetailsOfPersons("Kretika", "Arora", "home", "faridabad", "haryana", 121001, 96578, "k@gmail.com");
            addressBook.AddDetailsOfPersons("hey", "Arora", "hme", "fridabad", "hayana", 121001, 96578, "k@gmail.com");
            addressBook.AddDetailsOfPersons("Kretika", "Arora", "home", "faridabad", "haryana", 12100178965, 96578, "k@gmail.com");
            addressBook.AddDetailsOfPersons("Kretika", "Arora", "home", "faridabad", "haryana", 121001, 96578, "k@gmail.com");
            addressBook.DisplayContactPersonDetails();


        }
    }
}
