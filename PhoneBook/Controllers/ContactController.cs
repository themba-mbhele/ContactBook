using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Interfaces.Services;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService ContactService;
        public ContactController(IContactService contactService) => ContactService = contactService;
        public ActionResult Index()
        {
            var contactViewModel = new ContactViewModel(ContactService);
            contactViewModel.GetContacts();

            return View(contactViewModel);
        }

        [HttpPost]
        public ActionResult Index([FromForm]ContactViewModel viewModel)
        {
            var contactViewModel = new ContactViewModel(ContactService);
            contactViewModel.AddContact(viewModel.NewContact);

            ModelState.Clear();

            return Index();
        }
    }
}
