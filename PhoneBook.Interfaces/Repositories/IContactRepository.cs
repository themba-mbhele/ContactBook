using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Interfaces.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();
        bool AddContact(Contact contact);
    }
}
