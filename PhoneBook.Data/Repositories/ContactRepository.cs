using Microsoft.EntityFrameworkCore;
using PhoneBook.Interfaces.Repositories;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneBookContext context;

        public ContactRepository(PhoneBookContext context)
        {
            this.context = context;
        }

        public bool AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            return (context.SaveChanges() > 0);
        }

        public List<Contact> GetContacts() => context.Contacts.ToList();
    }
}
