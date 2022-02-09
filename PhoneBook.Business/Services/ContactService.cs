using PhoneBook.Interfaces.Repositories;
using PhoneBook.Interfaces.Services;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Business.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository ContactRepository;
        public ContactService(IContactRepository contactRepository) => ContactRepository = contactRepository;


        public bool AddContact(Contact contact) => ContactRepository.AddContact(contact);

        public List<Contact> GetContacts() => ContactRepository.GetContacts();
    }
}
