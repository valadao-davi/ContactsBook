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


    }
}
