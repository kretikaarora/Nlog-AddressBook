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
        public void AddDetailsOfPersons()
        {
            while (true)
            {
                Again: Console.WriteLine("Enter the details of contact person");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    nLog.LogInfo("no more contacts given");
                    break;
                        
                }
                string lastName = Console.ReadLine();
                string address = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                double zip = Convert.ToDouble(Console.ReadLine());
                double phoneNo = Convert.ToDouble(Console.ReadLine());
                string email = Console.ReadLine();



                if (zip.ToString().Length > 10)
                {
                    nLog.LogError("invalid potal code, please enter a valid zip code ");
                    goto Again;
                }
                if(phoneNo.ToString().Length > 10)
                {
                    nLog.LogError("invalid phone number, please enter a 10 digit phone number ");
                    Console.WriteLine("enter a valid 10 digit phone number");
                }

                ContactPerson contactPerson = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNo, email);
                // if (addressBookList.Contains(contactPerson))
                // {
                //   nLog.LogError("Details are already there , add some other value");
                // Console.WriteLine("enter new contact details");
                //}
                // else
                //{

                addressBookList.Add(contactPerson);
                nLog.LogInfo("Contact Details Addition Succesful:AddDetailsOfPersons()");
                //}
            }


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
                nLog.LogDebug("Displaying Contact Details Successful :DisplayContactPersonDetails()");
            }
        }
    }
}
