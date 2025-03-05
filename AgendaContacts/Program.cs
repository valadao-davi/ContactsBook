namespace AgendaContacts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Contact cont = new Contact("Davi", "099982", "davitest@gmail.com");
            ContactsBook myContactsBook = new ContactsBook();
            Console.WriteLine("Adding contact: ");
            myContactsBook.AddContact(cont);
            Console.WriteLine("\n");

            Console.WriteLine("Searching contact by phone number");
            Console.WriteLine("Existing contact: ");
            myContactsBook.SearchContactsByPhone("099982");
            Console.WriteLine("\n");
            Console.WriteLine("Non-Existing contact: ");
            myContactsBook.SearchContactsByPhone("099983");
            Console.WriteLine("\n");


            Console.WriteLine("Editing existing contact: ");
            Contact cont2 = new Contact("Davi10", "13123123123123", "davinovo.valadao@gmail.com");
            myContactsBook.EditContact(cont2, "099982");
            Console.WriteLine("\n");

            Console.WriteLine("Deleting existing contact: ");
            myContactsBook.DeleteContact("13123123123123");
        }
    }
}