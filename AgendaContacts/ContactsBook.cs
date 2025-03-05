using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacts
{
    class ContactsBook
    {
        private readonly Dictionary<string, Contact> contactsBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            if (contactsBook.ContainsKey(contact.PhoneNumber))
            {
                Console.WriteLine("Error already in your contact book.");
            }
            else
            {
                contactsBook.Add(contact.PhoneNumber, contact);
                Console.WriteLine("Contact added.");

            }
        }

        public void searchContactsByPhone(string phoneNumber)
        {
            if (contactsBook.ContainsKey(phoneNumber))
            {
                Console.WriteLine(contactsBook[phoneNumber]);
            }
            else
            {
                Console.WriteLine("Phone not founded");
            }
        }

        public void editContact(Contact contact)
        {
            if (contactsBook.ContainsKey(contact.PhoneNumber))
            {
                contactsBook
            }
        }
    }
}
