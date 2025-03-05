using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgendaContacts
{
    class Contact
    {
        private string _name = "";
        private string _phoneNumber = "";
        private string _email = "";

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name
        {
            get { return _name;  }
            set {
                if (value.Length > 0 && value != null)
                {
                    _name = value;
                } 
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set {
                if (Regex.IsMatch(value, @"^[0-9]+$"))
                {
                    Console.WriteLine("Valid value.");
                    _phoneNumber = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if(value.Contains("@") && value.Contains(".com"))
                {
                    _email = value;
                }
            }
        }
    }
}
