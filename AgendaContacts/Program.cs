namespace AgendaContacts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Contact cont = new Contact("Davi", "11988295788", "davinovo.valadao@gmail.com");
            ContactsBook contactsBook = new ContactsBook();
            contactsBook.AddContact(cont);
            Contact cont2 = new Contact("Davi10", "13123123123123", "davinovo.valadao@gmail.com");
            contactsBook.EditContact(cont2, "11988295788");
        }
    }
}