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

        public void SearchContactsByPhone(string phoneNumber)
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

        public void EditContact(Contact newContact, string searchPhone)
        {
            if (contactsBook.ContainsKey(searchPhone))
            {
                contactsBook.Remove(searchPhone);
                contactsBook[newContact.PhoneNumber] = newContact;
                Console.WriteLine(contactsBook[newContact.PhoneNumber]);
            }
            else
            {
                Console.WriteLine("Contact not founded");
            }
        }

        public void DeleteContact(string phoneNumber)
        {
            if (contactsBook.ContainsKey(phoneNumber))
            {
                contactsBook.Remove(phoneNumber);
                Console.WriteLine("Contact deleted with sucess.");
            }
            else
            {
                Console.WriteLine("Phone not founded");
            }
        }
    }
}
