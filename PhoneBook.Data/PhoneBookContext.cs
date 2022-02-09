using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;
using System;

namespace PhoneBook.Data
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
