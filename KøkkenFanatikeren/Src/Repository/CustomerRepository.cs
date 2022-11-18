using KøkkenFanatikeren.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Repository
{
    public class CustomerRepository : Interface.ICustomer
    {
        private Database.KitchenFanaticContext Context;

        public CustomerRepository(Database.KitchenFanaticContext context)
        {
            Context = context;
        }

        public void DeleteCustomer(Database.Customer customer)
        {
            throw new NotImplementedException();
        }

        public Database.Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database.Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Database.Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Database.Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
