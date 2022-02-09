using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Data;
using PhoneBook.Interfaces;
using PhoneBook.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal static class ConfigureDependencyInjection
    {
        internal static void InjectDataRepositories(IServiceCollection services)
        {
            services.AddTransient<PhoneBookContext>();

            services.AddTransient<Interfaces.Repositories.IContactRepository, Data.Repositories.ContactRepository>();
        }

        internal static void InjectBusinessServices(IServiceCollection services)
        {
            services.AddTransient<Interfaces.Services.IContactService, Business.Services.ContactService>();
        }
    }
}
