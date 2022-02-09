using PhoneBook.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class ContactViewModel
    {
        #region Properties
        private readonly IContactService ContactService;


        public string Test { get; set; }
        public Contact NewContact { get; set; } = new Contact();

        public List<Contact> Contacts { get; set; }
        #endregion

        #region Constructor

        public ContactViewModel() { }
        public ContactViewModel(IContactService contactService) => ContactService = contactService;

        #endregion

        #region Methods

        public void GetContacts() => Contacts = ContactService.GetContacts();

        public bool AddContact(Contact contact) => ContactService.AddContact(contact);

        public List<Contact> Search(string searchString) => ContactService.Search(searchString);

        #endregion
    }
}
