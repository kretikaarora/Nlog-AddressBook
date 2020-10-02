using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NLog;

namespace NlogAddressBook
{
    class AddressBook
    {
        private List<ContactPerson> addressBookList;
        private readonly NLog nLog = new NLog();
        public AddressBook()
        {
            addressBookList = new List<ContactPerson>();


        }
        public void AddDetailsOfPersons(string firstName, string lastName, string address, string city, string state, long zip, long phoneNo, string eMail)
        {
           if (zip.ToString().Length >10)
            {
                nLog.LogError("invalid potal code, please enter a valid zip code ");
            }
            
            ContactPerson contactPerson = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNo, eMail);
           // if (addressBookList.Contains(contactPerson))
           // {
             //   nLog.LogError("Details are already there , add some other value");
               // Console.WriteLine("enter new contact details");
            //}
            //else
            //{
                addressBookList.Add(contactPerson);
                nLog.LogInfo("Contact Details Addition Succesful:AddDetailsOfPersons()");
           // }


        }


        public void DisplayContactPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (ContactPerson contactPerson in addressBookList)
            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                Console.WriteLine("firstName : " + contactPerson.firstName + "  last name  :" + contactPerson.lastName + " address : " + contactPerson.address + " city : " + contactPerson.city + " state : " + contactPerson.state + "  zip : " + contactPerson.zip + " phone number : " + contactPerson.phoneNo + "  email :" + contactPerson.email);
                numberOfPersons++;
                Console.WriteLine("******************************************************************************************");
            }
        }
    }
}
