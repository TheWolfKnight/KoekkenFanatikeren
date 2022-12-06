using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Services
{
    internal class CustomerService
    {
        public Database.KitchenFanaticDataContext Context;

        public CustomerService(Database.KitchenFanaticDataContext ctx) => Context = ctx;

        public Database.Customer GitCustomerInfo(int id)
        {
            Repository.CustomerRepository cr = new Repository.CustomerRepository(Context);

            return cr.GetEntryById(id);
        }

    }
}
