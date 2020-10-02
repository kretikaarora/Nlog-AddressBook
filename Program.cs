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
            addressBook.AddDetailsOfPersons();
            addressBook.DisplayContactPersonDetails();


        }
    }
}
