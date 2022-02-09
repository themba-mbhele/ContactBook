using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Interfaces.Services
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        bool AddContact(Contact contact);
    }
}
